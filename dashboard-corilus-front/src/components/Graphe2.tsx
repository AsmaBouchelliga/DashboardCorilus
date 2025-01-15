import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";
import { ApexOptions } from "apexcharts";
import { Card, CardHeader, CardBody } from "reactstrap";
import { Icon } from "@iconify/react/dist/iconify.js";
import axios from "../config/axios";
import "../assets/css/graphe1.css";

interface PaymentDto {
  typePayment: string;
  paiementRecu: number;
}

interface PaymentsData {
  payments: PaymentDto[];
}

interface UserProps {
  currentUser: string;
  period: number;
  refreshing: number;
  moveUpOrDown: () => void;
}

const Graphe2: React.FC<UserProps> = (props) => {
  const {
    currentUser = "63c0579b-a9b7-4c00-bb4a-a5ed00fb2b58",
    period = 300,
    refreshing = 0,
  } = props;

  const [labels, setLabels] = useState<string[]>([]);
  const [colors, setColors] = useState(["#ff8042", "#0088fe", "#00c49f"]);

  const [paymentDetails, setPaymentDetails] = useState<PaymentsData>({ payments: [] });
  const [paymentData, setPaymentData] = useState<number[]>([]);

  useEffect(() => {
    const endDate = new Date();
    const startDate = new Date();
    startDate.setDate(endDate.getDate() - period);

    fetchData(currentUser, startDate, endDate);
  }, [refreshing]);

  const fetchData = async (
    selectedUserId: string,
    startDate: Date,
    endDate: Date
  ) => {
    try {
      const response = await axios.get<PaymentDto[]>(
        `https://localhost:7232/payment/total-payments/${selectedUserId}`,
        {
          params: {
            startDate: startDate.toISOString(),
            endDate: endDate.toISOString(),
          },
        }
      );

      if (response?.status === 200) {
        const items = response.data;

        const labelsHolder: string[] = items.map(item => item.typePayment);
        const paymentDataHolder: number[] = items.map(item => item.paiementRecu);

        setLabels(labelsHolder);
        setPaymentData(paymentDataHolder);
        setPaymentDetails({ payments: items });
      }
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  };

  const handlePrint = () => {
    window.print();
  };

  const options: ApexOptions = {
    series: [
      {
        name: "Paiements",
        data: paymentData,
      }
    ],
    chart: {
      type: "bar",
      height: 350,
    },
    plotOptions: {
      bar: {
        horizontal: false,
        columnWidth: "55%",
      },
    },
    dataLabels: {
      enabled: false,
    },
    stroke: {
      show: true,
      width: 2,
      colors: ["transparent"],
    },
    xaxis: {
      categories: labels,
    },
    fill: {
      opacity: 1,
    },
    tooltip: {
      y: {
        formatter: (val) => `€ ${val}`,
      },
    },
  };

  const optionsPie: ApexOptions = {
    legend: {
      show: true,
      position: "bottom",
    },
    labels: labels,
    series: paymentData,
    colors: colors,
    dataLabels: {
      enabled: true,
      formatter: (val) => `${parseInt(val.toString())}%`,
    },
    plotOptions: {
      pie: {
        customScale: 0.8,
      },
    },
    responsive: [
      {
        breakpoint: 992,
        options: {
          chart: {
            height: 380,
          },
          legend: {
            position: "bottom",
          },
        },
      },
      {
        breakpoint: 576,
        options: {
          chart: {
            height: 320,
          },
          plotOptions: {
            pie: {
              donut: {
                labels: {
                  show: true,
                  name: {
                    fontSize: "1.5rem",
                  },
                  value: {
                    fontSize: "1rem",
                  },
                  total: {
                    fontSize: "1.5rem",
                  },
                },
              },
            },
          },
        },
      },
    ],
  };

  return (
    <Card>
      <CardHeader className="text-left">
        <div className="d-flex justify-content-between">
          <div>Total des paiements reçus : {paymentDetails.payments.reduce((total, item) => total + item.paiementRecu, 0)} €</div>
          <div>
            <Icon
              icon="typcn:pin"
              width="30"
              height="30"
              style={{ color: "#707070" }}
              onClick={props.moveUpOrDown}
            />
            <Icon
              icon="material-symbols:info"
              width="30"
              height="30"
              style={{ color: "#1ba796" }}
            />
            <Icon
              icon="mingcute:time-fill"
              width="30"
              height="30"
              style={{ color: "#707070" }}
            />
          </div>
        </div>
      </CardHeader>
      <CardBody className="pb-0">
        <div className="d-flex justify-content-between">
          <div className="custom-top-padding-7 custom-left-padding-7">
            <div className="d-flex justify-content-around">
              <div>
                {paymentDetails.payments.map((payment, index) => (
                  <div key={index} className="custom-bottom-padding-2">
                    {payment.typePayment} : {payment.paiementRecu}€
                  </div>
                ))}
              </div>
            </div>
            <button className="btn btn-outline-dark" onClick={handlePrint}>
              Imprimer le rapport de paiement
            </button>
          </div>
          <div style={{ height: "401px" }}>
            <Chart
              options={optionsPie}
              series={optionsPie.series}
              type="pie"
              height={400}
            />
          </div>
          <div style={{ height: "401px" }}>
            <Chart
              options={options}
              type="bar"
              series={options.series}
              height={400}
            />
          </div>
        </div>
      </CardBody>
    </Card>
  );
};

export default Graphe2;
