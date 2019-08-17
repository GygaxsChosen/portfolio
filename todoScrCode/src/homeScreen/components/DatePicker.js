import 'date-fns';
import React from 'react';
import Grid from '@material-ui/core/Grid';
import DateFnsUtils from '@date-io/date-fns';
import {
    MuiPickersUtilsProvider,
    KeyboardTimePicker,
    KeyboardDatePicker,
} from '@material-ui/pickers';

 export const MaterialUIPickers=(props) => {
    // The first commit of Material-UI
    const [selectedDate, setSelectedDate] = React.useState(new Date());

    function handleDateChange(date) {
        setSelectedDate(date);
        props.pullDateForward(date);
    }

    return (
        <MuiPickersUtilsProvider utils={DateFnsUtils}>
            <Grid container >
                <KeyboardDatePicker
                    disableToolbar
                    variant="inline"
                    format="MM/dd/yyyy"
                    margin="none"
                    id="date-picker-inline"
                    label="Date of Task"
                    value={selectedDate}
                    onChange={handleDateChange}
                    KeyboardButtonProps={{
                        'aria-label': 'change date',
                    }}
                />
            </Grid>
        </MuiPickersUtilsProvider>
    );
}