using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000017 RID: 23
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptExpeditionScRsp : IMessage<AcceptExpeditionScRsp>, IMessage, IEquatable<AcceptExpeditionScRsp>, IDeepCloneable<AcceptExpeditionScRsp>, IBufferMessage
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003B69 File Offset: 0x00001D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptExpeditionScRsp> Parser
		{
			get
			{
				return AcceptExpeditionScRsp._parser;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00003B70 File Offset: 0x00001D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptExpeditionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003B82 File Offset: 0x00001D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptExpeditionScRsp.Descriptor;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003B89 File Offset: 0x00001D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptExpeditionScRsp()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003B94 File Offset: 0x00001D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptExpeditionScRsp(AcceptExpeditionScRsp other) : this()
		{
			this.fUNCUNLOCKIDEXPEDITION_ = ((other.fUNCUNLOCKIDEXPEDITION_ != null) ? other.fUNCUNLOCKIDEXPEDITION_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003BE0 File Offset: 0x00001DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptExpeditionScRsp Clone()
		{
			return new AcceptExpeditionScRsp(this);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00003BF0 File Offset: 0x00001DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLHHCIJPOPD FUNCUNLOCKIDEXPEDITION
		{
			get
			{
				return this.fUNCUNLOCKIDEXPEDITION_;
			}
			set
			{
				this.fUNCUNLOCKIDEXPEDITION_ = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003BF9 File Offset: 0x00001DF9
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00003C01 File Offset: 0x00001E01
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

		// Token: 0x060000C4 RID: 196 RVA: 0x00003C0A File Offset: 0x00001E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptExpeditionScRsp);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003C18 File Offset: 0x00001E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptExpeditionScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.FUNCUNLOCKIDEXPEDITION, other.FUNCUNLOCKIDEXPEDITION) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003C68 File Offset: 0x00001E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fUNCUNLOCKIDEXPEDITION_ != null)
			{
				num ^= this.FUNCUNLOCKIDEXPEDITION.GetHashCode();
			}
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

		// Token: 0x060000C7 RID: 199 RVA: 0x00003CBD File Offset: 0x00001EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003CC5 File Offset: 0x00001EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003CD0 File Offset: 0x00001ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fUNCUNLOCKIDEXPEDITION_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FUNCUNLOCKIDEXPEDITION);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003D2C File Offset: 0x00001F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fUNCUNLOCKIDEXPEDITION_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FUNCUNLOCKIDEXPEDITION);
			}
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

		// Token: 0x060000CB RID: 203 RVA: 0x00003D84 File Offset: 0x00001F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptExpeditionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fUNCUNLOCKIDEXPEDITION_ != null)
			{
				if (this.fUNCUNLOCKIDEXPEDITION_ == null)
				{
					this.FUNCUNLOCKIDEXPEDITION = new JLHHCIJPOPD();
				}
				this.FUNCUNLOCKIDEXPEDITION.MergeFrom(other.FUNCUNLOCKIDEXPEDITION);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003DEC File Offset: 0x00001FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 96U)
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
					if (this.fUNCUNLOCKIDEXPEDITION_ == null)
					{
						this.FUNCUNLOCKIDEXPEDITION = new JLHHCIJPOPD();
					}
					input.ReadMessage(this.FUNCUNLOCKIDEXPEDITION);
				}
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly MessageParser<AcceptExpeditionScRsp> _parser = new MessageParser<AcceptExpeditionScRsp>(() => new AcceptExpeditionScRsp());

		// Token: 0x04000045 RID: 69
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000046 RID: 70
		public const int FUNCUNLOCKIDEXPEDITIONFieldNumber = 2;

		// Token: 0x04000047 RID: 71
		private JLHHCIJPOPD fUNCUNLOCKIDEXPEDITION_;

		// Token: 0x04000048 RID: 72
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04000049 RID: 73
		private uint retcode_;
	}
}
