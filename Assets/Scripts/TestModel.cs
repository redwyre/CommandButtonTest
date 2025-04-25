using Assets.Scripts;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TestModel : MonoBehaviour
{
    public TestViewModel viewModel = new();
    public UIDocument uiDocument;

    public void Awake()
    {
        uiDocument.rootVisualElement.dataSource = viewModel;
    }
}

