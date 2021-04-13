from flask import Flask,render_template,request,jsonify

app=Flask(__name__)

@app.route('/',methods=['GET','POST'])
def index():
    if request.method=='POST':
        xyz=request.form.to_dict(flat=False)
        print (str(xyz['flag'][0]))
    return jsonify(xyz['flag'][0])

if '__app__'=='__main__':
    app.run(debug=True)