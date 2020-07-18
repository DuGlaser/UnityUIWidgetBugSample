using System.Collections.Generic;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

public class Main : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new MaterialApp(
            home: new HomeScreen()
        );
    }
}
