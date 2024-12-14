using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200099F RID: 2463
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KGHFJPEGBNL : IMessage<KGHFJPEGBNL>, IMessage, IEquatable<KGHFJPEGBNL>, IDeepCloneable<KGHFJPEGBNL>, IBufferMessage
	{
		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06006E1A RID: 28186 RVA: 0x00126360 File Offset: 0x00124560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KGHFJPEGBNL> Parser
		{
			get
			{
				return KGHFJPEGBNL._parser;
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06006E1B RID: 28187 RVA: 0x00126367 File Offset: 0x00124567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KGHFJPEGBNLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x00126379 File Offset: 0x00124579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KGHFJPEGBNL.Descriptor;
			}
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x00126380 File Offset: 0x00124580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGHFJPEGBNL()
		{
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x00126388 File Offset: 0x00124588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGHFJPEGBNL(KGHFJPEGBNL other) : this()
		{
			this.dCHPHIMIEFP_ = other.dCHPHIMIEFP_;
			this.scriptId_ = other.scriptId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x001263B9 File Offset: 0x001245B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGHFJPEGBNL Clone()
		{
			return new KGHFJPEGBNL(this);
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06006E20 RID: 28192 RVA: 0x001263C1 File Offset: 0x001245C1
		// (set) Token: 0x06006E21 RID: 28193 RVA: 0x001263C9 File Offset: 0x001245C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DCHPHIMIEFP
		{
			get
			{
				return this.dCHPHIMIEFP_;
			}
			set
			{
				this.dCHPHIMIEFP_ = value;
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x001263D2 File Offset: 0x001245D2
		// (set) Token: 0x06006E23 RID: 28195 RVA: 0x001263DA File Offset: 0x001245DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x001263E3 File Offset: 0x001245E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KGHFJPEGBNL);
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x001263F1 File Offset: 0x001245F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KGHFJPEGBNL other)
		{
			return other != null && (other == this || (this.DCHPHIMIEFP == other.DCHPHIMIEFP && this.ScriptId == other.ScriptId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x00126430 File Offset: 0x00124630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DCHPHIMIEFP != 0U)
			{
				num ^= this.DCHPHIMIEFP.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x00126488 File Offset: 0x00124688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x00126490 File Offset: 0x00124690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x0012649C File Offset: 0x0012469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.DCHPHIMIEFP != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DCHPHIMIEFP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x001264F8 File Offset: 0x001246F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DCHPHIMIEFP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DCHPHIMIEFP);
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x00126550 File Offset: 0x00124750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KGHFJPEGBNL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DCHPHIMIEFP != 0U)
			{
				this.DCHPHIMIEFP = other.DCHPHIMIEFP;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x001265A0 File Offset: 0x001247A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x001265AC File Offset: 0x001247AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DCHPHIMIEFP = input.ReadUInt32();
					}
				}
				else
				{
					this.ScriptId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002A4B RID: 10827
		private static readonly MessageParser<KGHFJPEGBNL> _parser = new MessageParser<KGHFJPEGBNL>(() => new KGHFJPEGBNL());

		// Token: 0x04002A4C RID: 10828
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A4D RID: 10829
		public const int DCHPHIMIEFPFieldNumber = 10;

		// Token: 0x04002A4E RID: 10830
		private uint dCHPHIMIEFP_;

		// Token: 0x04002A4F RID: 10831
		public const int ScriptIdFieldNumber = 7;

		// Token: 0x04002A50 RID: 10832
		private uint scriptId_;
	}
}
