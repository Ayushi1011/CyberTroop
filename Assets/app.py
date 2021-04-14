from flask import Flask,render_template,request,jsonify

app=Flask(__name__)



@app.route('/',methods=['GET','POST'])
def index():
    global y
    if request.method=='POST':
        global xyz
        xyz=request.form.to_dict(flat=False)
        y=getdata(xyz)
        #  print(y)
    return getdata(xyz)
def getdata(xyz):
        if str(xyz['flag'][0]) == "61":
            return "correct"
        else:
            return "incorrect"
        return jsonify(xyz['flag'][0])
     #return "111"

@app.route('/q2',methods=['GET','POST'])
def index1():
    global y
    if request.method=='POST':
        global xyz
        xyz=request.form.to_dict(flat=False)
        y=getdata1(xyz)
        #  print(y)
    return getdata1(xyz)
def getdata1(xyz):
        if str(xyz['flag'][0]) == "l3arn_th3_r0p35":
            return "correct"
        else:
            return "incorrect"
        return jsonify(xyz['flag'][0])
     #return "111"

if '__app__'=='__main__':
    app.run(host= '0.0.0.0',port=8000)   