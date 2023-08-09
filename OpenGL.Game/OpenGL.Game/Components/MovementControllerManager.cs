using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OpenGL.Game.Components
{
    public class MovementControllerManager : Component
    {
        public static MovementControllerManager Instance {get; private set;}

        private int currentlySelectedMovementControllerIndex = 0;
        private MovementController currentlySelectedMovementController;

        private List<MovementController> allMovementControllers = new List<MovementController>();

        public MovementControllerManager()
        {
            if(Instance == null)
            {
            Instance = this;
            InputHelper.ButtonSpacePressedEvent += SelectNextMovementController;
            }
        }

        public void MakeControllerActive(MovementController controller)
        {
            //Disable the previously selected controller
            currentlySelectedMovementController.MovementEnabled = false;
            currentlySelectedMovementController.RotationEnabled = false;

            //Set the controller as selected
            currentlySelectedMovementController = controller;
            currentlySelectedMovementControllerIndex = allMovementControllers.IndexOf(controller);

            //Activate the controller
            currentlySelectedMovementController.MovementEnabled = true;
            currentlySelectedMovementController.RotationEnabled = true;

            ChangeUITextToSelectedController();
        }
        public override void OnAwake()
        {
            allMovementControllers.Clear();
            currentlySelectedMovementController = null;
            currentlySelectedMovementControllerIndex = 0;
        }

        public override void OnStart()
        {
        }

        public override void OnUpdate()
        {
        }

        public override void OnDisable()
        {
            allMovementControllers.Clear();
            currentlySelectedMovementController = null;
            currentlySelectedMovementControllerIndex = 0;
        }
        /// <summary>
        /// This method increments the currentlySelectedMovementControllerIndex by 1, selects and makes the next MovementController in the allMovementControllers List active.
        /// </summary>
        /// <param name="isPressed"></param>
        public void SelectNextMovementController(bool isPressed)
        {
            if (!isPressed) return;

            currentlySelectedMovementController.MovementEnabled = false;
            currentlySelectedMovementController.RotationEnabled = false;
            currentlySelectedMovementControllerIndex++;
            currentlySelectedMovementController = allMovementControllers[currentlySelectedMovementControllerIndex % allMovementControllers.Count];
            currentlySelectedMovementController.MovementEnabled = true;
            currentlySelectedMovementController.RotationEnabled = true;

            ChangeUITextToSelectedController();
        }

        private void ChangeUITextToSelectedController()
        {
            if (!gameObject.game.UserInterfaceHelper.IsUIInitalized) return;

            gameObject.game.UserInterfaceHelper.currentlySelectedText.String = currentlySelectedMovementController.GameObject.Name;
        }

        public void AddMovementController(MovementController controller)
        {
            allMovementControllers.Add(controller);

            if (currentlySelectedMovementController != null)
            {
                currentlySelectedMovementController.MovementEnabled = false;
                currentlySelectedMovementController.RotationEnabled = false;
            }

            currentlySelectedMovementController = controller;
            currentlySelectedMovementControllerIndex = allMovementControllers.IndexOf(controller);

            currentlySelectedMovementController.MovementEnabled = true;
            currentlySelectedMovementController.RotationEnabled = true;

            ChangeUITextToSelectedController();
        }
    }
}