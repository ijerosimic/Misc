<template>
  <div class="col-lg-12">
    <div class="row">
      <quote-counter :width="progressBar.width" :counter="progressBar.count"></quote-counter>
    </div>
    <div id="inner">
      <h5>Quote</h5>
      <textarea v-model="quote"></textarea>
      <div id="buttonDiv">
        <button type="button" class="btn btn-primary" @click="addQuote">Add quote</button>
      </div>
    </div>
  </div>
</template>

<script>
import { progressBarBus } from "../main.js";
import { quoteAdderBus } from "../main.js";
import { quoteRemoverBus } from "../main.js";
import QuoteCounter from "./QuoteCounter";

export default {
  data() {
    return {
      progressBar: {
        count: 0,
        width: 0
      },
      quote: ""
    };
  },
  methods: {
    addQuote() {
      if (this.quote.text != "") {
        let progressBar = this.progressBar;
        progressBar.count = this.progressBar.count += 1;
        progressBar.width = this.progressBar.width += 10;
        progressBarBus.$emit("progressWasChanged", progressBar);

        quoteAdderBus.$emit("quoteWasAdded", this.quote);
        this.quote.text === null;
      }
    }
  },
  components: {
    quoteCounter: QuoteCounter
  },
  created() {
    quoteRemoverBus.$on("quoteWasRemoved", data => {
      this.progressBar.count --;
      console.log(this.progressBar.count);
    });
  }
};
</script>

<style>
#inner,
textarea {
  width: 50%;
  margin: 0 auto;
}

#buttonDiv {
  text-align: center;
}

textarea {
  resize: none;
  width: 100%;
  height: 200px;
}
</style>
