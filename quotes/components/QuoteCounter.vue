<template>
  <div class="col-lg-12">
    <h1>Quotes Added</h1>
    <div class="progress">
      <div class="progress-bar" role="progressbar" :style="{width: barWidth + '%'}">{{barCount}}/10</div>
    </div>
  </div>
</template>

<script>
import { progressBarBus } from "../main.js";

export default {
  data: function() {
    return {
      barCount: 0,
      barWidth: 0
    };
  },
  created() {
    progressBarBus.$on("progressWasChanged", progressBar => {
      this.barCount = progressBar.count;
      this.barWidth = progressBar.width;
    });
  },
  watch: {
    barCount: function() {
      if (this.barCount > 10) {
        alert(
          "You have added the maximum number of quotes. Delete some before adding new quotes! Bitch!"
        );
        this.barCount = 10;
        this.barWidth = 100;
      }
    }
  }
};
</script>

<style>
.progress {
  height: 25px;
}

.progress-bar {
  font-size: 1.1rem;
}
</style>



counter and width are props
they will come via event bus
they will be bound to a data element
data element will be inserted in html