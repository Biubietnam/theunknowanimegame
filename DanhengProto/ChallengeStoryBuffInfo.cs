using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001BD RID: 445
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStoryBuffInfo : IMessage<ChallengeStoryBuffInfo>, IMessage, IEquatable<ChallengeStoryBuffInfo>, IDeepCloneable<ChallengeStoryBuffInfo>, IBufferMessage
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x00039984 File Offset: 0x00037B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStoryBuffInfo> Parser
		{
			get
			{
				return ChallengeStoryBuffInfo._parser;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0003998B File Offset: 0x00037B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryBuffInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0003999D File Offset: 0x00037B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStoryBuffInfo.Descriptor;
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000399A4 File Offset: 0x00037BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffInfo()
		{
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x000399AC File Offset: 0x00037BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffInfo(ChallengeStoryBuffInfo other) : this()
		{
			this.buffOne_ = other.buffOne_;
			this.buffTwo_ = other.buffTwo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x000399DD File Offset: 0x00037BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffInfo Clone()
		{
			return new ChallengeStoryBuffInfo(this);
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x000399E5 File Offset: 0x00037BE5
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x000399ED File Offset: 0x00037BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffOne
		{
			get
			{
				return this.buffOne_;
			}
			set
			{
				this.buffOne_ = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x000399F6 File Offset: 0x00037BF6
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x000399FE File Offset: 0x00037BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffTwo
		{
			get
			{
				return this.buffTwo_;
			}
			set
			{
				this.buffTwo_ = value;
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00039A07 File Offset: 0x00037C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStoryBuffInfo);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00039A15 File Offset: 0x00037C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStoryBuffInfo other)
		{
			return other != null && (other == this || (this.BuffOne == other.BuffOne && this.BuffTwo == other.BuffTwo && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00039A54 File Offset: 0x00037C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffOne != 0U)
			{
				num ^= this.BuffOne.GetHashCode();
			}
			if (this.BuffTwo != 0U)
			{
				num ^= this.BuffTwo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00039AAC File Offset: 0x00037CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00039AB4 File Offset: 0x00037CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00039AC0 File Offset: 0x00037CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffOne != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BuffOne);
			}
			if (this.BuffTwo != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.BuffTwo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00039B1C File Offset: 0x00037D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffOne != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffOne);
			}
			if (this.BuffTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffTwo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00039B74 File Offset: 0x00037D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStoryBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffOne != 0U)
			{
				this.BuffOne = other.BuffOne;
			}
			if (other.BuffTwo != 0U)
			{
				this.BuffTwo = other.BuffTwo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00039BC4 File Offset: 0x00037DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00039BD0 File Offset: 0x00037DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BuffTwo = input.ReadUInt32();
					}
				}
				else
				{
					this.BuffOne = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400086B RID: 2155
		private static readonly MessageParser<ChallengeStoryBuffInfo> _parser = new MessageParser<ChallengeStoryBuffInfo>(() => new ChallengeStoryBuffInfo());

		// Token: 0x0400086C RID: 2156
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400086D RID: 2157
		public const int BuffOneFieldNumber = 4;

		// Token: 0x0400086E RID: 2158
		private uint buffOne_;

		// Token: 0x0400086F RID: 2159
		public const int BuffTwoFieldNumber = 8;

		// Token: 0x04000870 RID: 2160
		private uint buffTwo_;
	}
}
