import './App.css';
import office from './images/office.jpg';

function App() {

  const officeList = [
    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai"
    },
    {
      Name: "Regus",
      Rent: 65000,
      Address: "Bangalore"
    },
    {
      Name: "WeWork",
      Rent: 75000,
      Address: "Hyderabad"
    }
  ];

  return (
    <div style={{ marginLeft: "40px" }}>

      <h1>Office Space, at Affordable Range</h1>

      <img
        src={office}
        alt="Office Space"
        width="300"
        height="200"
      />

      {
        officeList.map((item, index) => (

          <div key={index}>

            <h2>Name: {item.Name}</h2>

            <h3
              style={{
                color: item.Rent <= 60000 ? "red" : "green"
              }}
            >
              Rent: Rs. {item.Rent}
            </h3>

            <h3>
              Address: {item.Address}
            </h3>

            <hr />

          </div>

        ))
      }

    </div>
  );
}

export default App;