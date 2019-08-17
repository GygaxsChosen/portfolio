import React from 'react';
import Button from '@material-ui/core/Button';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

export const GuestWarning=(props)=> {
    const [open, setOpen] = React.useState(true);

    function handleClickOpen() {
        setOpen(true);
    }

    function handleClose() {
        setOpen(false);

        props.onProceed();
    }

    return (
        <div>
            <Dialog
                open={open}
                onClose={handleClose}
                aria-labelledby="alert-dialog-title"
                aria-describedby="alert-dialog-description"
            >
                <DialogTitle id="alert-dialog-title">{"Notes will not be saved!"}</DialogTitle>
                <DialogContent>
                    <DialogContentText id="alert-dialog-description">
                       Please note continuing as a guest will prevent any saving of to-do Items from occurring.

                        if you wish to preserve your notes and retrieve them later, please click back and create/login to your account
                    </DialogContentText>
                </DialogContent>
                <DialogActions>
                    <Button onClick={handleClose} color="primary">
                        Back
                    </Button>
                    <Button onClick={handleClose} color="primary" autoFocus >
                        Continue as Guest.
                    </Button>
                </DialogActions>
            </Dialog>
        </div>
    );
}