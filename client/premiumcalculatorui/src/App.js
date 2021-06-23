import './App.css';
// import AppHeader from './components/AppHeader';
import UserInputForm from './components/UserInputForm'

function App() {
  return (
    <div className="jumbotron">
      <div className="container">
        <div className="col-md-8 offset-md-2">

          <UserInputForm />
        </div>
      </div>
    </div>
  );
}

export default App;
