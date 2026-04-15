const express = require("express");
const app = express();

app.use(express.json());

app.post("/validate-shot", (req, res) => {
    const { position, speed } = req.body;

    if (speed > 20) {
        return res.status(403).send("Cheat detected");
    }

    res.send("OK");
});

app.listen(3000);
