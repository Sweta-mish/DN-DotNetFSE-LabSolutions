import './App.css';
import EventExamples from './Components/EventExamples';
import CurrencyConvertor from './Components/CurrencyConvertor';

function App() {

  return (
    <div style={{ margin: "20px" }}>

      <EventExamples />

      <br />
      <br />

      <CurrencyConvertor />

    </div>
  );
}

export default App;