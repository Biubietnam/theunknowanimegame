using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000015 RID: 21
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptExpeditionCsReq : IMessage<AcceptExpeditionCsReq>, IMessage, IEquatable<AcceptExpeditionCsReq>, IDeepCloneable<AcceptExpeditionCsReq>, IBufferMessage
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000389D File Offset: 0x00001A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptExpeditionCsReq> Parser
		{
			get
			{
				return AcceptExpeditionCsReq._parser;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000038A4 File Offset: 0x00001AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptExpeditionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000038B6 File Offset: 0x00001AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptExpeditionCsReq.Descriptor;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000038BD File Offset: 0x00001ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptExpeditionCsReq()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000038C5 File Offset: 0x00001AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptExpeditionCsReq(AcceptExpeditionCsReq other) : this()
		{
			this.fUNCUNLOCKIDEXPEDITION_ = ((other.fUNCUNLOCKIDEXPEDITION_ != null) ? other.fUNCUNLOCKIDEXPEDITION_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000038FA File Offset: 0x00001AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptExpeditionCsReq Clone()
		{
			return new AcceptExpeditionCsReq(this);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003902 File Offset: 0x00001B02
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000390A File Offset: 0x00001B0A
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

		// Token: 0x060000AD RID: 173 RVA: 0x00003913 File Offset: 0x00001B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptExpeditionCsReq);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003921 File Offset: 0x00001B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptExpeditionCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.FUNCUNLOCKIDEXPEDITION, other.FUNCUNLOCKIDEXPEDITION) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003954 File Offset: 0x00001B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fUNCUNLOCKIDEXPEDITION_ != null)
			{
				num ^= this.FUNCUNLOCKIDEXPEDITION.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003990 File Offset: 0x00001B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003998 File Offset: 0x00001B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000039A1 File Offset: 0x00001BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fUNCUNLOCKIDEXPEDITION_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.FUNCUNLOCKIDEXPEDITION);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000039D4 File Offset: 0x00001BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fUNCUNLOCKIDEXPEDITION_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FUNCUNLOCKIDEXPEDITION);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003A14 File Offset: 0x00001C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptExpeditionCsReq other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003A68 File Offset: 0x00001C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003A74 File Offset: 0x00001C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x0400003F RID: 63
		private static readonly MessageParser<AcceptExpeditionCsReq> _parser = new MessageParser<AcceptExpeditionCsReq>(() => new AcceptExpeditionCsReq());

		// Token: 0x04000040 RID: 64
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000041 RID: 65
		public const int FUNCUNLOCKIDEXPEDITIONFieldNumber = 11;

		// Token: 0x04000042 RID: 66
		private JLHHCIJPOPD fUNCUNLOCKIDEXPEDITION_;
	}
}
