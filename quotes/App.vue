<template>
  <div class="container">
    <div class="row">
      <quote-adder></quote-adder>
    </div>
    <div class="row">
      <keep-alive>
        <quote-container></quote-container>
      </keep-alive>
    </div>
  </div>
</template>

<script>
import Bootstrap from "../node_modules/bootstrap/dist/css/bootstrap.min.css";

import QuoteAdder from "./components/QuoteAdder";
import QuoteContainer from "./components/QuoteContainer";

export default {
  components: {
    quoteAdder: QuoteAdder,
    quoteContainer: QuoteContainer
  }
};
</script>

<style>
.row {
  padding: 20px;
}
</style>
