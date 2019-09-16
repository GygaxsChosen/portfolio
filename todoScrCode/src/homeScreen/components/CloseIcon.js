import React from 'react';
import clsx from 'clsx';
import Button from '@material-ui/core/Button';
import { makeStyles } from '@material-ui/core/styles';
import DeleteIcon from '@material-ui/icons/Delete';
import CloudUploadIcon from '@material-ui/icons/CloudUpload';
import KeyboardVoiceIcon from '@material-ui/icons/KeyboardVoice';
import Icon from '@material-ui/core/Icon';
import SaveIcon from '@material-ui/icons/Save';

const useStyles = makeStyles(theme => ({
    button: {
        margin: theme.spacing(1),
    },
    leftIcon: {
        marginRight: theme.spacing(1),
    },
    rightIcon: {
        marginLeft: theme.spacing(1),
    },
    iconSmall: {
        fontSize: 20,
    },
}));

export const CloseIcon=(props)=> {
    const classes = useStyles();

    return (
        <div>
            <Button variant="contained" size="small" className={classes.button} onClick={props.close}>
                close
            </Button><Button variant="contained" size="small" className={classes.button} onClick={props.previousNote}>
                Previous Note
            </Button><Button variant="contained" size="small" className={classes.button} onClick={props.nextNote}>
                Next Note
            </Button>
            <div onClick={props.delete}>
                <DeleteIcon>

                </DeleteIcon>
            </div>


        </div>
    );
}
