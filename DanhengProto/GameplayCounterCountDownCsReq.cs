using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D9 RID: 1497
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameplayCounterCountDownCsReq : IMessage<GameplayCounterCountDownCsReq>, IMessage, IEquatable<GameplayCounterCountDownCsReq>, IDeepCloneable<GameplayCounterCountDownCsReq>, IBufferMessage
	{
		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x000B6291 File Offset: 0x000B4491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayCounterCountDownCsReq> Parser
		{
			get
			{
				return GameplayCounterCountDownCsReq._parser;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x000B6298 File Offset: 0x000B4498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameplayCounterCountDownCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x000B62AA File Offset: 0x000B44AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCounterCountDownCsReq.Descriptor;
			}
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x000B62B1 File Offset: 0x000B44B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterCountDownCsReq()
		{
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x000B62B9 File Offset: 0x000B44B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterCountDownCsReq(GameplayCounterCountDownCsReq other) : this()
		{
			this.nNCFPDLCNHN_ = other.nNCFPDLCNHN_;
			this.curTimes_ = other.curTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x000B62EA File Offset: 0x000B44EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterCountDownCsReq Clone()
		{
			return new GameplayCounterCountDownCsReq(this);
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x000B62F2 File Offset: 0x000B44F2
		// (set) Token: 0x060042E2 RID: 17122 RVA: 0x000B62FA File Offset: 0x000B44FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NNCFPDLCNHN
		{
			get
			{
				return this.nNCFPDLCNHN_;
			}
			set
			{
				this.nNCFPDLCNHN_ = value;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x000B6303 File Offset: 0x000B4503
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x000B630B File Offset: 0x000B450B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurTimes
		{
			get
			{
				return this.curTimes_;
			}
			set
			{
				this.curTimes_ = value;
			}
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x000B6314 File Offset: 0x000B4514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCounterCountDownCsReq);
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x000B6322 File Offset: 0x000B4522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCounterCountDownCsReq other)
		{
			return other != null && (other == this || (this.NNCFPDLCNHN == other.NNCFPDLCNHN && this.CurTimes == other.CurTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x000B6360 File Offset: 0x000B4560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NNCFPDLCNHN != 0U)
			{
				num ^= this.NNCFPDLCNHN.GetHashCode();
			}
			if (this.CurTimes != 0U)
			{
				num ^= this.CurTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000B63B8 File Offset: 0x000B45B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x000B63C0 File Offset: 0x000B45C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x000B63CC File Offset: 0x000B45CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurTimes != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CurTimes);
			}
			if (this.NNCFPDLCNHN != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.NNCFPDLCNHN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x000B6428 File Offset: 0x000B4628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NNCFPDLCNHN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NNCFPDLCNHN);
			}
			if (this.CurTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x000B6480 File Offset: 0x000B4680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCounterCountDownCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NNCFPDLCNHN != 0U)
			{
				this.NNCFPDLCNHN = other.NNCFPDLCNHN;
			}
			if (other.CurTimes != 0U)
			{
				this.CurTimes = other.CurTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x000B64D0 File Offset: 0x000B46D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x000B64DC File Offset: 0x000B46DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NNCFPDLCNHN = input.ReadUInt32();
					}
				}
				else
				{
					this.CurTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001A8F RID: 6799
		private static readonly MessageParser<GameplayCounterCountDownCsReq> _parser = new MessageParser<GameplayCounterCountDownCsReq>(() => new GameplayCounterCountDownCsReq());

		// Token: 0x04001A90 RID: 6800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A91 RID: 6801
		public const int NNCFPDLCNHNFieldNumber = 13;

		// Token: 0x04001A92 RID: 6802
		private uint nNCFPDLCNHN_;

		// Token: 0x04001A93 RID: 6803
		public const int CurTimesFieldNumber = 6;

		// Token: 0x04001A94 RID: 6804
		private uint curTimes_;
	}
}
