using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000193 RID: 403
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossBuffInfo : IMessage<ChallengeBossBuffInfo>, IMessage, IEquatable<ChallengeBossBuffInfo>, IDeepCloneable<ChallengeBossBuffInfo>, IBufferMessage
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00033D2C File Offset: 0x00031F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossBuffInfo> Parser
		{
			get
			{
				return ChallengeBossBuffInfo._parser;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00033D33 File Offset: 0x00031F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossBuffInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x00033D45 File Offset: 0x00031F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossBuffInfo.Descriptor;
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00033D4C File Offset: 0x00031F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffInfo()
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00033D54 File Offset: 0x00031F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffInfo(ChallengeBossBuffInfo other) : this()
		{
			this.buffTwo_ = other.buffTwo_;
			this.buffOne_ = other.buffOne_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00033D85 File Offset: 0x00031F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossBuffInfo Clone()
		{
			return new ChallengeBossBuffInfo(this);
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00033D8D File Offset: 0x00031F8D
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x00033D95 File Offset: 0x00031F95
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00033D9E File Offset: 0x00031F9E
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x00033DA6 File Offset: 0x00031FA6
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

		// Token: 0x06001205 RID: 4613 RVA: 0x00033DAF File Offset: 0x00031FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossBuffInfo);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00033DBD File Offset: 0x00031FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossBuffInfo other)
		{
			return other != null && (other == this || (this.BuffTwo == other.BuffTwo && this.BuffOne == other.BuffOne && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00033DFC File Offset: 0x00031FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffTwo != 0U)
			{
				num ^= this.BuffTwo.GetHashCode();
			}
			if (this.BuffOne != 0U)
			{
				num ^= this.BuffOne.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00033E54 File Offset: 0x00032054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00033E5C File Offset: 0x0003205C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00033E68 File Offset: 0x00032068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffOne != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BuffOne);
			}
			if (this.BuffTwo != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BuffTwo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00033EC0 File Offset: 0x000320C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffTwo != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffTwo);
			}
			if (this.BuffOne != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffOne);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00033F18 File Offset: 0x00032118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffTwo != 0U)
			{
				this.BuffTwo = other.BuffTwo;
			}
			if (other.BuffOne != 0U)
			{
				this.BuffOne = other.BuffOne;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00033F68 File Offset: 0x00032168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00033F74 File Offset: 0x00032174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 56U)
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

		// Token: 0x0400078E RID: 1934
		private static readonly MessageParser<ChallengeBossBuffInfo> _parser = new MessageParser<ChallengeBossBuffInfo>(() => new ChallengeBossBuffInfo());

		// Token: 0x0400078F RID: 1935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000790 RID: 1936
		public const int BuffTwoFieldNumber = 7;

		// Token: 0x04000791 RID: 1937
		private uint buffTwo_;

		// Token: 0x04000792 RID: 1938
		public const int BuffOneFieldNumber = 1;

		// Token: 0x04000793 RID: 1939
		private uint buffOne_;
	}
}
