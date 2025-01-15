import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";
import { ApexOptions } from "apexcharts";
import { Card, CardHeader, CardBody } from "reactstrap";
import { Icon } from "@iconify/react";
import axios from "../config/axios";
import "../assets/css/graphe1.css";

interface CombinedReportDto {
  nbAttest: number;
  montantTotalAttestedSessions: number;
  nbInvoices: number;
  montantTotalElectronicInvoices: number;
}

interface UserProps {
  currentUser: string;
  period: number;
  refreshing: number;
  moveUpOrDown: () => void;
}

const Graphe5: React.FC<UserProps> = (props) => {
  const {
    currentUser,
    period,
    refreshing,
  } = props;

  const [series, setSeries] = useState<number[]>([]);
  const [numberOfCertificates, setNumberOfCertificates] = useState<string>("");
  const [numberOfEfacts, setNumberOfEfacts] = useState<string>("");
  const [total, setTotal] = useState<number>(0);
  const [startDate, setStartDate] = useState<string>("2023-01-01");
  const [endDate, setEndDate] = useState<string>(new Date().toISOString().split('T')[0]);

  useEffect(() => {
    fetchData(currentUser, startDate, endDate);
  }, [refreshing, startDate, endDate]);

  const fetchData = async (selectedUserId: string, startDate: string, endDate: string) => {
    try {
      const response = await axios.get<CombinedReportDto>(
        `https://localhost:7232/RejectedStats/combined-report`,
        {
          params: {
            userId: selectedUserId,
            startDate,
            endDate,
          },
        }
      );

      if (response.status === 200) {
        const data = response.data;
        const dataHolder = [data.nbAttest, data.nbInvoices];

        setNumberOfCertificates(data.nbAttest.toString());
        setNumberOfEfacts(data.nbInvoices.toString());
        setTotal(data.montantTotalAttestedSessions + data.montantTotalElectronicInvoices);
        setSeries(dataHolder);
      }
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  };

  const optionsBar: ApexOptions = {
    series: [
      {
        name: "Ce Mois-ci",
        data: series,
      },
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
      categories: ["Attestations", "eFacts"],
    },
    yaxis: {
      title: {
        text: "Montant totale des rejets",
      },
    },
    fill: {
      opacity: 1,
    },
    tooltip: {
      y: {
        formatter: function (val) {
          return "€ " + val;
        },
      },
    },
  };

  return (
    <Card>
      <CardHeader className="text-left">
        <div className="d-flex justify-content-between">
          <div>Total des attestations et factures rejetées : {total} €</div>
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
                <div>Montant totale des attestation rejetées:</div>
                <div className="custom-bottom-padding-2">
                  Nombre d'attestation rejetées:
                </div>
                <div>Montant totale des eFacts rejetées:</div>
                <div className="custom-bottom-padding-2">
                  Nombre d'eFacts rejetées:
                </div>
              </div>
              <div>
                <div className="fw-bold">
                  {total.toFixed(2)}€
                </div>
                <div className="custom-bottom-padding-2 fw-bold">
                  {numberOfCertificates}
                </div>
                <div className=" fw-bold">
                  {total.toFixed(2)}€
                </div>
                <div className="custom-bottom-padding-2 fw-bold">
                  {numberOfEfacts}
                </div>
              </div>
            </div>
            <button className="btn btn-outline-dark">
              Gérer les rejets
              <Icon
                icon="tabler:external-link"
                width="30"
                height="30"
                style={{ color: "#707070" }}
              />
            </button>
          </div>
          <div style={{ height: "401px" }}>
            <Chart
              options={optionsBar}
              type="bar"
              series={optionsBar.series}
              height={400}
            />
          </div>
        </div>
      </CardBody>
    </Card>
  );
};

export default Graphe5;
