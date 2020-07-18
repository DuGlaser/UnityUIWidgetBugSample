using System.Collections.Generic;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

public class SecondScreen : StatefulWidget
{
    public override State createState()
    {
        return new _SecondScreen();
    }
}

class _SecondScreen : State<HomeScreen>
{
    public override Widget build(BuildContext context)
    {
        Size deviseSize = MediaQuery.of(context).size;
        return new Theme(
            data: new ThemeData(),
            child: new Scaffold(
                appBar: new AppBar(title: new Text("Test App")),
                body: new Container(
                    child: new Column(
                        children: new List<Widget>{
                            new Column(
                                children: new List<Widget>{
                                    new Container(
                                        padding: EdgeInsets.fromLTRB(deviseSize.width * .03f, deviseSize.height * .03f, deviseSize.width * .03f, deviseSize.height * .01f),
                                        width: deviseSize.width,
                                        color: Colors.black12,
                                        child: new Text(
                                            "samplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesample",
                                            style: new TextStyle(
                                                height: deviseSize.height * .0018f
                                            )
                                        )
                                    ),
                                    new Container(
                                        padding: EdgeInsets.fromLTRB(deviseSize.width * .03f, deviseSize.height * .03f, deviseSize.width * .03f, deviseSize.height * .01f),
                                        width: deviseSize.width,
                                        color: Colors.white,
                                        child: new Text(
                                            "samplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesample",
                                            style: new TextStyle(
                                                height: deviseSize.height * .0018f
                                            )
                                        )
                                    ),
                                }
                            ),
                            new Column(
                                children: new List<Widget>{
                                    new Container(
                                        padding: EdgeInsets.fromLTRB(deviseSize.width * .03f, deviseSize.height * .03f, deviseSize.width * .03f, deviseSize.height * .01f),
                                        width: deviseSize.width,
                                        color: Colors.black12,
                                        child: new Text(
                                            "samplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesample",
                                            style: new TextStyle(
                                                height: deviseSize.height * .0018f
                                            )
                                        )
                                    ),
                                    new Container(
                                        padding: EdgeInsets.fromLTRB(deviseSize.width * .03f, deviseSize.height * .03f, deviseSize.width * .03f, deviseSize.height * .01f),
                                        width: deviseSize.width,
                                        color: Colors.white,
                                        child: new Text(
                                            "samplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesample",
                                            style: new TextStyle(
                                                height: deviseSize.height * .0018f
                                            )
                                        )
                                    ),
                                }
                            ),
                        }
                    )
                )
            )
        );
    }
}
