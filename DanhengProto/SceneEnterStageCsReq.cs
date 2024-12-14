using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200105B RID: 4187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEnterStageCsReq : IMessage<SceneEnterStageCsReq>, IMessage, IEquatable<SceneEnterStageCsReq>, IDeepCloneable<SceneEnterStageCsReq>, IBufferMessage
	{
		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600BA70 RID: 47728 RVA: 0x001F529F File Offset: 0x001F349F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEnterStageCsReq> Parser
		{
			get
			{
				return SceneEnterStageCsReq._parser;
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600BA71 RID: 47729 RVA: 0x001F52A6 File Offset: 0x001F34A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEnterStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600BA72 RID: 47730 RVA: 0x001F52B8 File Offset: 0x001F34B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEnterStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600BA73 RID: 47731 RVA: 0x001F52BF File Offset: 0x001F34BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEnterStageCsReq()
		{
		}

		// Token: 0x0600BA74 RID: 47732 RVA: 0x001F52C7 File Offset: 0x001F34C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEnterStageCsReq(SceneEnterStageCsReq other) : this()
		{
			this.gJBOOFHBEOP_ = other.gJBOOFHBEOP_;
			this.rebattleType_ = other.rebattleType_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA75 RID: 47733 RVA: 0x001F5304 File Offset: 0x001F3504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEnterStageCsReq Clone()
		{
			return new SceneEnterStageCsReq(this);
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600BA76 RID: 47734 RVA: 0x001F530C File Offset: 0x001F350C
		// (set) Token: 0x0600BA77 RID: 47735 RVA: 0x001F5314 File Offset: 0x001F3514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GJBOOFHBEOP
		{
			get
			{
				return this.gJBOOFHBEOP_;
			}
			set
			{
				this.gJBOOFHBEOP_ = value;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600BA78 RID: 47736 RVA: 0x001F531D File Offset: 0x001F351D
		// (set) Token: 0x0600BA79 RID: 47737 RVA: 0x001F5325 File Offset: 0x001F3525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RebattleType RebattleType
		{
			get
			{
				return this.rebattleType_;
			}
			set
			{
				this.rebattleType_ = value;
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x001F532E File Offset: 0x001F352E
		// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x001F5336 File Offset: 0x001F3536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x0600BA7C RID: 47740 RVA: 0x001F533F File Offset: 0x001F353F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEnterStageCsReq);
		}

		// Token: 0x0600BA7D RID: 47741 RVA: 0x001F5350 File Offset: 0x001F3550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEnterStageCsReq other)
		{
			return other != null && (other == this || (this.GJBOOFHBEOP == other.GJBOOFHBEOP && this.RebattleType == other.RebattleType && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA7E RID: 47742 RVA: 0x001F53AC File Offset: 0x001F35AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GJBOOFHBEOP)
			{
				num ^= this.GJBOOFHBEOP.GetHashCode();
			}
			if (this.RebattleType != RebattleType.None)
			{
				num ^= this.RebattleType.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA7F RID: 47743 RVA: 0x001F5423 File Offset: 0x001F3623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BA80 RID: 47744 RVA: 0x001F542B File Offset: 0x001F362B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x001F5434 File Offset: 0x001F3634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RebattleType != RebattleType.None)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.RebattleType);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EventId);
			}
			if (this.GJBOOFHBEOP)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.GJBOOFHBEOP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x001F54AC File Offset: 0x001F36AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GJBOOFHBEOP)
			{
				num += 2;
			}
			if (this.RebattleType != RebattleType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RebattleType);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA83 RID: 47747 RVA: 0x001F5510 File Offset: 0x001F3710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEnterStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GJBOOFHBEOP)
			{
				this.GJBOOFHBEOP = other.GJBOOFHBEOP;
			}
			if (other.RebattleType != RebattleType.None)
			{
				this.RebattleType = other.RebattleType;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x001F5574 File Offset: 0x001F3774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x001F5580 File Offset: 0x001F3780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GJBOOFHBEOP = input.ReadBool();
						}
					}
					else
					{
						this.EventId = input.ReadUInt32();
					}
				}
				else
				{
					this.RebattleType = (RebattleType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B9D RID: 19357
		private static readonly MessageParser<SceneEnterStageCsReq> _parser = new MessageParser<SceneEnterStageCsReq>(() => new SceneEnterStageCsReq());

		// Token: 0x04004B9E RID: 19358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B9F RID: 19359
		public const int GJBOOFHBEOPFieldNumber = 13;

		// Token: 0x04004BA0 RID: 19360
		private bool gJBOOFHBEOP_;

		// Token: 0x04004BA1 RID: 19361
		public const int RebattleTypeFieldNumber = 8;

		// Token: 0x04004BA2 RID: 19362
		private RebattleType rebattleType_;

		// Token: 0x04004BA3 RID: 19363
		public const int EventIdFieldNumber = 12;

		// Token: 0x04004BA4 RID: 19364
		private uint eventId_;
	}
}
