import React from 'react';
import './App.css';
import StyledComponents from './homeScreen/components/StyledPanel'
import { FirebaseDatabaseProvider } from "@react-firebase/database";

class App extends React.Component {

  constructor(props) {
    super(props);

  }

  render() {

    return (
        <FirebaseDatabaseProvider>
      <div >

        <StyledComponents
        />
      </div>
        </FirebaseDatabaseProvider>
  );
  }


}

export default App;
