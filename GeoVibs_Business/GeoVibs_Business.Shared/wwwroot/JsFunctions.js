window.LoadingJs = {
    ToggleLoading: (loading) => {
        const loadingElement = document.getElementById("app-loading");
        const backdropElement = document.getElementById("app-loading-backdrop");
        if (!loadingElement) return;

        loadingElement.classList.toggle("show-loading", loading);
    }
};
