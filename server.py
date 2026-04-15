from flask import Flask, jsonify

app = Flask(__name__)

@app.route("/score")
def score():
    return jsonify({"score": 100})

app.run()
