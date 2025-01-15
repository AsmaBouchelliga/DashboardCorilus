import { useEffect, useState } from "react";
import axios from "./config/axios";
import Graphe1 from "./components/Graphe1";
import Graphe2 from "./components/Graphe2";
import Graphe3 from "./components/Graphe3";
import Graphe4 from "./components/Graphe4";
import Graphe5 from "./components/Graphe5";
import Graphe6 from "./components/Graphe6";
import {
  Card,
  CardTitle,
  CardHeader,
  Col,
  Input,
  Label,
  CardBody,
  Row,
  Container,
  Button,
} from "reactstrap";

function App() {
  // ui states
  const [count, setCount] = useState<number>(0);
  const [charts, setCharts] = useState<any>([]);
  // filter states
  const [userId, setUserId] = useState<any[]>([]);
  const [number, setNumber] = useState<number>(300);
  const [currentUser, setCurrentUser] = useState<string>("63c0579b-a9b7-4c00-bb4a-a5ed00fb2b58");

  const passedProps = {
    currentUser: currentUser ?? "",
    period: number ?? 0,
    refreshing: count,
  };

  // Handle printing
  const handlePrint = () => {
    window.print();
  };

  // @utility: initial render: fetch user data and set the charts
  useEffect(() => {
    setCharts([
      { key: 1, component: Graphe1, aboveTitle: false },
      { key: 2, component: Graphe2, aboveTitle: false },
      { key: 3, component: Graphe3, aboveTitle: false },
      { key: 4, component: Graphe4, aboveTitle: false },
      { key: 5, component: Graphe5, aboveTitle: false },
      { key: 6, component: Graphe6, aboveTitle: false },
    ]);

    (async () => {
      try {
        const response = await axios.get("https://localhost:7232/api/User/all-user");
        if (response.status === 200) {
          setUserId(response.data);
        }
      } catch (error) {
        console.log("Error fetching data", error);
      }
    })();
  }, []);

  const handleInputChange = (event: any) => {
    setNumber(event.target.value);
  };

  const handleSelectChange = (event: any) => {
    setCurrentUser(event.target.value);
  };

  console.log("number of days", number);
  console.log("Current user", currentUser);

  return (
    <>
      <Card>
        <CardTitle className="ps-5 pt-3 h4">Dashboard Tarification</CardTitle>
        <hr />
        <CardBody>
          <Container>
            <Row xs="2" className="pb-4">
              <Col lg="3">
                <Label>Utilisateurs</Label>
              </Col>
              <Col lg="3">
                <Input id="user" type="select" value={currentUser} onChange={handleSelectChange}>
                  {userId?.map((user, index) => (
                    <option key={index} value={user.userId}>
                      {user.firstname} {user.lastname}
                    </option>
                  ))}
                </Input>
              </Col>
            </Row>
            <Row xs="2">
              <Col lg="3">
                <Label>Période</Label>
              </Col>
              <Col lg="3">
                <Input lg="6" type="number" id="period" onChange={handleInputChange} value={number} />
              </Col>
            </Row>
          </Container>
          <div className="mb-3">
            <Button onClick={() => setCount((prev) => prev + 1)} className="btn-custom me-3">
              Filtrer
            </Button>
            <Button className="btn-custom" onClick={handlePrint}>
              Imprimer Dashboard
            </Button>
          </div>
        </CardBody>
      </Card>
      <h3 className="text-capitalize border-bottom pb-2 mt-1">My Dashboard</h3>
      <Row>
        {charts
          .filter((item: any) => item.aboveTitle === true)
          .map((item: any) => {
            const { component: Component, key } = item;
            return (
              <Col key={key} lg={6} xl={6} sm={12} md={12} className="me-0">
                <div className="mx-1 my-3">
                  <Component
                    {...passedProps}
                    moveUpOrDown={() => {
                      setCharts((prev: any) =>
                        prev.map((chart: any) =>
                          chart.key === key ? { ...chart, aboveTitle: false } : chart
                        )
                      );
                    }}
                  />
                </div>
              </Col>
            );
          })}
        <div className="text-capitalize border-bottom pb-2 mt-1">
          <h3>general dashboard</h3>
        </div>
        {charts
          .filter((item: any) => item.aboveTitle === false)
          .map((item: any) => {
            const { component: Component, key } = item;
            return (
              <Col key={key} lg={6} xl={6} sm={12} md={12} className="me-0">
                <div className="mx-1 my-3">
                  <Component
                    {...passedProps}
                    moveUpOrDown={() => {
                      setCharts((prev: any) =>
                        prev.map((chart: any) =>
                          chart.key === key ? { ...chart, aboveTitle: true } : chart
                        )
                      );
                    }}
                  />
                </div>
              </Col>
            );
          })}
      </Row>
    </>
  );
}

export default App;
