using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008A7 RID: 2215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeartDialTraceScriptCsReq : IMessage<HeartDialTraceScriptCsReq>, IMessage, IEquatable<HeartDialTraceScriptCsReq>, IDeepCloneable<HeartDialTraceScriptCsReq>, IBufferMessage
	{
		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x060062B9 RID: 25273 RVA: 0x001084C1 File Offset: 0x001066C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeartDialTraceScriptCsReq> Parser
		{
			get
			{
				return HeartDialTraceScriptCsReq._parser;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x060062BA RID: 25274 RVA: 0x001084C8 File Offset: 0x001066C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeartDialTraceScriptCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060062BB RID: 25275 RVA: 0x001084DA File Offset: 0x001066DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartDialTraceScriptCsReq.Descriptor;
			}
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x001084E1 File Offset: 0x001066E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialTraceScriptCsReq()
		{
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x001084E9 File Offset: 0x001066E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialTraceScriptCsReq(HeartDialTraceScriptCsReq other) : this()
		{
			this.eFICAOAAAPH_ = ((other.eFICAOAAAPH_ != null) ? other.eFICAOAAAPH_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x0010851E File Offset: 0x0010671E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialTraceScriptCsReq Clone()
		{
			return new HeartDialTraceScriptCsReq(this);
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x060062BF RID: 25279 RVA: 0x00108526 File Offset: 0x00106726
		// (set) Token: 0x060062C0 RID: 25280 RVA: 0x0010852E File Offset: 0x0010672E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGHFJPEGBNL EFICAOAAAPH
		{
			get
			{
				return this.eFICAOAAAPH_;
			}
			set
			{
				this.eFICAOAAAPH_ = value;
			}
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x00108537 File Offset: 0x00106737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartDialTraceScriptCsReq);
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x00108545 File Offset: 0x00106745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartDialTraceScriptCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.EFICAOAAAPH, other.EFICAOAAAPH) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x00108578 File Offset: 0x00106778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.eFICAOAAAPH_ != null)
			{
				num ^= this.EFICAOAAAPH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x001085B4 File Offset: 0x001067B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x001085BC File Offset: 0x001067BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x001085C5 File Offset: 0x001067C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.eFICAOAAAPH_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.EFICAOAAAPH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x001085F8 File Offset: 0x001067F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.eFICAOAAAPH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EFICAOAAAPH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x00108638 File Offset: 0x00106838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartDialTraceScriptCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.eFICAOAAAPH_ != null)
			{
				if (this.eFICAOAAAPH_ == null)
				{
					this.EFICAOAAAPH = new KGHFJPEGBNL();
				}
				this.EFICAOAAAPH.MergeFrom(other.EFICAOAAAPH);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x0010868C File Offset: 0x0010688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x00108698 File Offset: 0x00106898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.eFICAOAAAPH_ == null)
					{
						this.EFICAOAAAPH = new KGHFJPEGBNL();
					}
					input.ReadMessage(this.EFICAOAAAPH);
				}
			}
		}

		// Token: 0x04002601 RID: 9729
		private static readonly MessageParser<HeartDialTraceScriptCsReq> _parser = new MessageParser<HeartDialTraceScriptCsReq>(() => new HeartDialTraceScriptCsReq());

		// Token: 0x04002602 RID: 9730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002603 RID: 9731
		public const int EFICAOAAAPHFieldNumber = 9;

		// Token: 0x04002604 RID: 9732
		private KGHFJPEGBNL eFICAOAAAPH_;
	}
}
