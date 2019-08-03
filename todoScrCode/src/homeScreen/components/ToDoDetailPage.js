import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Typography from '@material-ui/core/Typography';



export default class ToDoDetailPage extends React.Component {

    constructor(props) {
        super(props);
        // Don't call this.setState() here!
       this.getStyles = this.getStyles.bind(this)
    }

    getStyles(){
        return makeStyles(theme => ({
            root: {
                padding: theme.spacing(3,2)
            }
        }))
    }

   render() {
        const classes = this.getStyles();
       return (
           <div>
               <Paper className={classes.root}>
                   <Typography variant="h5" component="h3">
                       This is a sheet of paper.
                   </Typography>
                   <Typography component="p">
                       Paper can be used to build surface or other elements for your application.
                   </Typography>
               </Paper>
           </div>
       );
   }


}