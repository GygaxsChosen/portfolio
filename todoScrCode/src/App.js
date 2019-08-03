import React from 'react';
import './App.css';
import LeftPanel from './homeScreen/components/LeftPanel.js'

class App extends React.Component {

  constructor(props) {
    super(props);

  }

  render() {
    return (
      <div >

        <LeftPanel
        />
      </div>
  );
  }


}

export default App;
