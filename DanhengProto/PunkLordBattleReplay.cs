using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D21 RID: 3361
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordBattleReplay : IMessage<PunkLordBattleReplay>, IMessage, IEquatable<PunkLordBattleReplay>, IDeepCloneable<PunkLordBattleReplay>, IBufferMessage
	{
		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x0600961A RID: 38426 RVA: 0x0018F351 File Offset: 0x0018D551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordBattleReplay> Parser
		{
			get
			{
				return PunkLordBattleReplay._parser;
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x0018F358 File Offset: 0x0018D558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleReplayReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0600961C RID: 38428 RVA: 0x0018F36A File Offset: 0x0018D56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordBattleReplay.Descriptor;
			}
		}

		// Token: 0x0600961D RID: 38429 RVA: 0x0018F371 File Offset: 0x0018D571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleReplay()
		{
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x0018F384 File Offset: 0x0018D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleReplay(PunkLordBattleReplay other) : this()
		{
			this.battleReplayKey_ = other.battleReplayKey_;
			this.replayInfo_ = ((other.replayInfo_ != null) ? other.replayInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x0018F3D0 File Offset: 0x0018D5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleReplay Clone()
		{
			return new PunkLordBattleReplay(this);
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x06009620 RID: 38432 RVA: 0x0018F3D8 File Offset: 0x0018D5D8
		// (set) Token: 0x06009621 RID: 38433 RVA: 0x0018F3E0 File Offset: 0x0018D5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BattleReplayKey
		{
			get
			{
				return this.battleReplayKey_;
			}
			set
			{
				this.battleReplayKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x06009622 RID: 38434 RVA: 0x0018F3F3 File Offset: 0x0018D5F3
		// (set) Token: 0x06009623 RID: 38435 RVA: 0x0018F3FB File Offset: 0x0018D5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplayInfo ReplayInfo
		{
			get
			{
				return this.replayInfo_;
			}
			set
			{
				this.replayInfo_ = value;
			}
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x0018F404 File Offset: 0x0018D604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordBattleReplay);
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x0018F414 File Offset: 0x0018D614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordBattleReplay other)
		{
			return other != null && (other == this || (!(this.BattleReplayKey != other.BattleReplayKey) && object.Equals(this.ReplayInfo, other.ReplayInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x0018F468 File Offset: 0x0018D668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleReplayKey.Length != 0)
			{
				num ^= this.BattleReplayKey.GetHashCode();
			}
			if (this.replayInfo_ != null)
			{
				num ^= this.ReplayInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x0018F4BF File Offset: 0x0018D6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009628 RID: 38440 RVA: 0x0018F4C7 File Offset: 0x0018D6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009629 RID: 38441 RVA: 0x0018F4D0 File Offset: 0x0018D6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleReplayKey.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.BattleReplayKey);
			}
			if (this.replayInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ReplayInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x0018F530 File Offset: 0x0018D730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleReplayKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleReplayKey);
			}
			if (this.replayInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReplayInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600962B RID: 38443 RVA: 0x0018F58C File Offset: 0x0018D78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordBattleReplay other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleReplayKey.Length != 0)
			{
				this.BattleReplayKey = other.BattleReplayKey;
			}
			if (other.replayInfo_ != null)
			{
				if (this.replayInfo_ == null)
				{
					this.ReplayInfo = new ReplayInfo();
				}
				this.ReplayInfo.MergeFrom(other.ReplayInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600962C RID: 38444 RVA: 0x0018F5F9 File Offset: 0x0018D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600962D RID: 38445 RVA: 0x0018F604 File Offset: 0x0018D804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.replayInfo_ == null)
						{
							this.ReplayInfo = new ReplayInfo();
						}
						input.ReadMessage(this.ReplayInfo);
					}
				}
				else
				{
					this.BattleReplayKey = input.ReadString();
				}
			}
		}

		// Token: 0x04003A37 RID: 14903
		private static readonly MessageParser<PunkLordBattleReplay> _parser = new MessageParser<PunkLordBattleReplay>(() => new PunkLordBattleReplay());

		// Token: 0x04003A38 RID: 14904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A39 RID: 14905
		public const int BattleReplayKeyFieldNumber = 1;

		// Token: 0x04003A3A RID: 14906
		private string battleReplayKey_ = "";

		// Token: 0x04003A3B RID: 14907
		public const int ReplayInfoFieldNumber = 2;

		// Token: 0x04003A3C RID: 14908
		private ReplayInfo replayInfo_;
	}
}
