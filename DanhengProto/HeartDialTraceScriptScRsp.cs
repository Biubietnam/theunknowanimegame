using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008A9 RID: 2217
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeartDialTraceScriptScRsp : IMessage<HeartDialTraceScriptScRsp>, IMessage, IEquatable<HeartDialTraceScriptScRsp>, IDeepCloneable<HeartDialTraceScriptScRsp>, IBufferMessage
	{
		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x0010878D File Offset: 0x0010698D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeartDialTraceScriptScRsp> Parser
		{
			get
			{
				return HeartDialTraceScriptScRsp._parser;
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x060062CF RID: 25295 RVA: 0x00108794 File Offset: 0x00106994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeartDialTraceScriptScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x001087A6 File Offset: 0x001069A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartDialTraceScriptScRsp.Descriptor;
			}
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x001087AD File Offset: 0x001069AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialTraceScriptScRsp()
		{
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x001087B8 File Offset: 0x001069B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialTraceScriptScRsp(HeartDialTraceScriptScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eFICAOAAAPH_ = ((other.eFICAOAAAPH_ != null) ? other.eFICAOAAAPH_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x00108804 File Offset: 0x00106A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialTraceScriptScRsp Clone()
		{
			return new HeartDialTraceScriptScRsp(this);
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x060062D4 RID: 25300 RVA: 0x0010880C File Offset: 0x00106A0C
		// (set) Token: 0x060062D5 RID: 25301 RVA: 0x00108814 File Offset: 0x00106A14
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

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x060062D6 RID: 25302 RVA: 0x0010881D File Offset: 0x00106A1D
		// (set) Token: 0x060062D7 RID: 25303 RVA: 0x00108825 File Offset: 0x00106A25
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

		// Token: 0x060062D8 RID: 25304 RVA: 0x0010882E File Offset: 0x00106A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartDialTraceScriptScRsp);
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x0010883C File Offset: 0x00106A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartDialTraceScriptScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.EFICAOAAAPH, other.EFICAOAAAPH) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x0010888C File Offset: 0x00106A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
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

		// Token: 0x060062DB RID: 25307 RVA: 0x001088E1 File Offset: 0x00106AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x001088E9 File Offset: 0x00106AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x001088F4 File Offset: 0x00106AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.eFICAOAAAPH_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.EFICAOAAAPH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x00108950 File Offset: 0x00106B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
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

		// Token: 0x060062DF RID: 25311 RVA: 0x001089A8 File Offset: 0x00106BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartDialTraceScriptScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
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

		// Token: 0x060062E0 RID: 25312 RVA: 0x00108A10 File Offset: 0x00106C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x00108A1C File Offset: 0x00106C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 66U)
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
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002606 RID: 9734
		private static readonly MessageParser<HeartDialTraceScriptScRsp> _parser = new MessageParser<HeartDialTraceScriptScRsp>(() => new HeartDialTraceScriptScRsp());

		// Token: 0x04002607 RID: 9735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002608 RID: 9736
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04002609 RID: 9737
		private uint retcode_;

		// Token: 0x0400260A RID: 9738
		public const int EFICAOAAAPHFieldNumber = 8;

		// Token: 0x0400260B RID: 9739
		private KGHFJPEGBNL eFICAOAAAPH_;
	}
}
