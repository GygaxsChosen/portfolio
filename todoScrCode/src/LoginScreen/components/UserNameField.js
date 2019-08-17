import React from 'react';
import clsx from 'clsx';
import { makeStyles } from '@material-ui/core/styles';
import MenuItem from '@material-ui/core/MenuItem';
import TextField from '@material-ui/core/TextField';

const useStyles = makeStyles(theme => ({
    container: {
        display: 'flex',
        flexWrap: 'wrap',
    },
    textField: {
        marginLeft: theme.spacing(1),
        marginRight: theme.spacing(1),
        width: 200,
    },
    dense: {
        marginTop: 19,
    },
    menu: {
        width: 200,
    },
}));


export default function UserNameField() {
    const classes = useStyles();
    const [values, setValues] = React.useState({
        name: '',
        password: ''
    });

    const handleChange = name => event => {
        setValues({ ...values, [name]: event.target.value });
    };

    return (
        <form className={classes.container} noValidate autoComplete="off">
            <TextField
                id="standard-name"
                label="UserName"
                className={classes.textField}
                value={values.name}
                onChange={handleChange('name')}
                margin="normal"

            />
            <TextField
                id="standard-name"
                label="Password"
                className={classes.textField}
                value={values.password}
                onChange={handleChange('password')}
                margin="normal"
                type='password'

            />
        </form>
    );
}