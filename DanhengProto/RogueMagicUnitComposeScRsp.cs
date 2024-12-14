using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F2B RID: 3883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitComposeScRsp : IMessage<RogueMagicUnitComposeScRsp>, IMessage, IEquatable<RogueMagicUnitComposeScRsp>, IDeepCloneable<RogueMagicUnitComposeScRsp>, IBufferMessage
	{
		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0600AD3D RID: 44349 RVA: 0x001D2050 File Offset: 0x001D0250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitComposeScRsp> Parser
		{
			get
			{
				return RogueMagicUnitComposeScRsp._parser;
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0600AD3E RID: 44350 RVA: 0x001D2057 File Offset: 0x001D0257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitComposeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x001D2069 File Offset: 0x001D0269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitComposeScRsp.Descriptor;
			}
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x001D2070 File Offset: 0x001D0270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitComposeScRsp()
		{
		}

		// Token: 0x0600AD41 RID: 44353 RVA: 0x001D2078 File Offset: 0x001D0278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitComposeScRsp(RogueMagicUnitComposeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x001D209D File Offset: 0x001D029D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitComposeScRsp Clone()
		{
			return new RogueMagicUnitComposeScRsp(this);
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0600AD43 RID: 44355 RVA: 0x001D20A5 File Offset: 0x001D02A5
		// (set) Token: 0x0600AD44 RID: 44356 RVA: 0x001D20AD File Offset: 0x001D02AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600AD45 RID: 44357 RVA: 0x001D20B6 File Offset: 0x001D02B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitComposeScRsp);
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x001D20C4 File Offset: 0x001D02C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitComposeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x001D20F4 File Offset: 0x001D02F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x001D2133 File Offset: 0x001D0333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x001D213B File Offset: 0x001D033B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x001D2144 File Offset: 0x001D0344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD4B RID: 44363 RVA: 0x001D2178 File Offset: 0x001D0378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD4C RID: 44364 RVA: 0x001D21B6 File Offset: 0x001D03B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitComposeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD4D RID: 44365 RVA: 0x001D21E7 File Offset: 0x001D03E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x001D21F0 File Offset: 0x001D03F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400468F RID: 18063
		private static readonly MessageParser<RogueMagicUnitComposeScRsp> _parser = new MessageParser<RogueMagicUnitComposeScRsp>(() => new RogueMagicUnitComposeScRsp());

		// Token: 0x04004690 RID: 18064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004691 RID: 18065
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004692 RID: 18066
		private uint retcode_;
	}
}
