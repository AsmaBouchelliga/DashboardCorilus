import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";
import { ApexOptions } from "apexcharts";
import { Card, CardHeader, CardBody } from "reactstrap";
import { Icon } from "@iconify/react";
import axios from "../config/axios";
import "../assets/css/graphe1.css";

interface NomenclatureStatsDto {
  nomenclatureCode: string;
  nombre: number;
  montantTotal: number;
}

interface UserProps {
  currentUser: string;
  period: number;
  refreshing: number;
  moveUpOrDown: () => void;
}

const Graphe6: React.FC<UserProps> = (props) => {
  const { currentUser, period, refreshing } = props;

  const [labels, setLabels] = useState<string[]>([]);
  const [colors, setColors] = useState<string[]>([
    "#ff8042",
    "#0088fe",
    "#00c49f",
    "#f2c94c",
    "#f2604c",
  ]);
  const [nomenclatureData, setNomenclatureData] = useState<NomenclatureStatsDto[]>([]);
  const [amount, setAmount] = useState<number[]>([]);

  useEffect(() => {
    fetchData(currentUser, period);
  }, [refreshing]);

  const fetchData = async (selectedUserId: string, selectedPeriode: number) => {
    try {
      const response = await axios.get<NomenclatureStatsDto[]>(
        `https://localhost:7232/RejectedStats/top-nomenclature-stats`,
        {
          params: {
            userId: selectedUserId,
            startDate: new Date(new Date().setDate(new Date().getDate() - selectedPeriode)).toISOString(),
            endDate: new Date().toISOString(),
          },
        }
      );

      if (response.status === 200) {
        const items = response.data;
        const labelsHolder = items.map(item => item.nomenclatureCode);
        const amountHolder = items.map(item => item.montantTotal);

        setLabels(labelsHolder);
        setAmount(amountHolder);
        setNomenclatureData(items);
      }
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  };

  const optionsPie: ApexOptions = {
    legend: {
      show: true,
      position: "bottom",
    },
    labels: labels,
    series: amount,
    colors: colors,
    dataLabels: {
      enabled: true,
      formatter(val: any) {
        return `${parseInt(val)}%`;
      },
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
            height: 480,
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
            height: 400,
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
          <div>Statistiques top 5 Nomenclature</div>
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
          <div className="custom-top-padding-2 custom-left-padding-7">
            <div className="d-flex justify-content-around">
              <div>
                {nomenclatureData.map((data, index) => (
                  <div key={index} className="custom-bottom-padding-1">
                    {index + 1}. {data.nomenclatureCode || "N/A"}
                    <div>Nombre totale: {data.nombre || "N/A"}</div>
                    <div>Montant totale : {data.montantTotal || "N/A"} €</div>
                  </div>
                ))}
              </div>
            </div>
            <button className="btn btn-outline-dark">
              Ouvrir la liste des prestations
            </button>
          </div>
          <div style={{ height: "401px" }}>
            <Chart
              options={optionsPie}
              series={optionsPie.series}
              type="pie"
              height={500}
            />
          </div>
        </div>
      </CardBody>
    </Card>
  );
};

export default Graphe6;
