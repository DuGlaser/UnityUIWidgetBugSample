using System.Collections.Generic;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

class HomeScreen : StatefulWidget
{
    public override State createState()
    {
        return new _HomeScreen();
    }
}

class _HomeScreen : State<HomeScreen>
{
    public override Widget build(BuildContext context)
    {
        Size deviseSize = MediaQuery.of(context).size;
        return new MaterialApp(
            home: new Scaffold(
                appBar: new AppBar(title: new Text("Test App")),
                body: new Container(
                ),
                floatingActionButton: new FloatingActionButton(
                    onPressed: () =>
                    {
                        Navigator.push(
                            context,
                            new MaterialPageRoute(
                                builder: (BuildContext => new SecondScreen())
                            )
                        );
                    }
                )
            )
        );
    }
}
