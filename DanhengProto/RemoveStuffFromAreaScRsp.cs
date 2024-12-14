using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB7 RID: 3511
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveStuffFromAreaScRsp : IMessage<RemoveStuffFromAreaScRsp>, IMessage, IEquatable<RemoveStuffFromAreaScRsp>, IDeepCloneable<RemoveStuffFromAreaScRsp>, IBufferMessage
	{
		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x06009CFA RID: 40186 RVA: 0x001A22BD File Offset: 0x001A04BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveStuffFromAreaScRsp> Parser
		{
			get
			{
				return RemoveStuffFromAreaScRsp._parser;
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x06009CFB RID: 40187 RVA: 0x001A22C4 File Offset: 0x001A04C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RemoveStuffFromAreaScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x06009CFC RID: 40188 RVA: 0x001A22D6 File Offset: 0x001A04D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveStuffFromAreaScRsp.Descriptor;
			}
		}

		// Token: 0x06009CFD RID: 40189 RVA: 0x001A22DD File Offset: 0x001A04DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveStuffFromAreaScRsp()
		{
		}

		// Token: 0x06009CFE RID: 40190 RVA: 0x001A22E5 File Offset: 0x001A04E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveStuffFromAreaScRsp(RemoveStuffFromAreaScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CFF RID: 40191 RVA: 0x001A2316 File Offset: 0x001A0516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveStuffFromAreaScRsp Clone()
		{
			return new RemoveStuffFromAreaScRsp(this);
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x06009D00 RID: 40192 RVA: 0x001A231E File Offset: 0x001A051E
		// (set) Token: 0x06009D01 RID: 40193 RVA: 0x001A2326 File Offset: 0x001A0526
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

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x06009D02 RID: 40194 RVA: 0x001A232F File Offset: 0x001A052F
		// (set) Token: 0x06009D03 RID: 40195 RVA: 0x001A2337 File Offset: 0x001A0537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x06009D04 RID: 40196 RVA: 0x001A2340 File Offset: 0x001A0540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveStuffFromAreaScRsp);
		}

		// Token: 0x06009D05 RID: 40197 RVA: 0x001A234E File Offset: 0x001A054E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveStuffFromAreaScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.POEDFMELAKE == other.POEDFMELAKE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D06 RID: 40198 RVA: 0x001A238C File Offset: 0x001A058C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D07 RID: 40199 RVA: 0x001A23E4 File Offset: 0x001A05E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D08 RID: 40200 RVA: 0x001A23EC File Offset: 0x001A05EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x001A23F8 File Offset: 0x001A05F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x001A2450 File Offset: 0x001A0650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x001A24A8 File Offset: 0x001A06A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveStuffFromAreaScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D0C RID: 40204 RVA: 0x001A24F8 File Offset: 0x001A06F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D0D RID: 40205 RVA: 0x001A2504 File Offset: 0x001A0704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.POEDFMELAKE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D06 RID: 15622
		private static readonly MessageParser<RemoveStuffFromAreaScRsp> _parser = new MessageParser<RemoveStuffFromAreaScRsp>(() => new RemoveStuffFromAreaScRsp());

		// Token: 0x04003D07 RID: 15623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D08 RID: 15624
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04003D09 RID: 15625
		private uint retcode_;

		// Token: 0x04003D0A RID: 15626
		public const int POEDFMELAKEFieldNumber = 1;

		// Token: 0x04003D0B RID: 15627
		private uint pOEDFMELAKE_;
	}
}
