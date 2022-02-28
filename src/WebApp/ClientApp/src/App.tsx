import Layout from "./layout/Layout";
import { Toaster } from "react-hot-toast";
import UserServiceProvider from "./providers/UserServiceProvider";
import { QueryClient, QueryClientProvider } from "react-query";
import { BrowserRouter } from "react-router-dom";

function App() {
  const queryClient = new QueryClient();

  return (
    <QueryClientProvider client={queryClient}>
      <BrowserRouter basename={process.env.PUBLIC_URL}>
        <UserServiceProvider>
          <Layout />
          <Toaster
            toastOptions={{
              success: {
                style: {
                  textTransform: "uppercase",
                  color: "#989898",
                  fontSize: ".875rem",
                },
              },
              error: {
                style: {
                  textTransform: "uppercase",
                  color: "#989898",
                  fontSize: ".875rem",
                },
              },
            }}
          />
        </UserServiceProvider>
      </BrowserRouter>
    </QueryClientProvider>
  );
}

export default App;
