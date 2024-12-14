using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AD3 RID: 2771
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MGLKKPJKBLJ : IMessage<MGLKKPJKBLJ>, IMessage, IEquatable<MGLKKPJKBLJ>, IDeepCloneable<MGLKKPJKBLJ>, IBufferMessage
	{
		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06007AC3 RID: 31427 RVA: 0x00145200 File Offset: 0x00143400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MGLKKPJKBLJ> Parser
		{
			get
			{
				return MGLKKPJKBLJ._parser;
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06007AC4 RID: 31428 RVA: 0x00145207 File Offset: 0x00143407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MGLKKPJKBLJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06007AC5 RID: 31429 RVA: 0x00145219 File Offset: 0x00143419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MGLKKPJKBLJ.Descriptor;
			}
		}

		// Token: 0x06007AC6 RID: 31430 RVA: 0x00145220 File Offset: 0x00143420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLKKPJKBLJ()
		{
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x00145228 File Offset: 0x00143428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLKKPJKBLJ(MGLKKPJKBLJ other) : this()
		{
			this.gGEPGHPENFG_ = other.gGEPGHPENFG_;
			this.fALLAINIGJD_ = other.fALLAINIGJD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x00145259 File Offset: 0x00143459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLKKPJKBLJ Clone()
		{
			return new MGLKKPJKBLJ(this);
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x06007AC9 RID: 31433 RVA: 0x00145261 File Offset: 0x00143461
		// (set) Token: 0x06007ACA RID: 31434 RVA: 0x00145269 File Offset: 0x00143469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GGEPGHPENFG
		{
			get
			{
				return this.gGEPGHPENFG_;
			}
			set
			{
				this.gGEPGHPENFG_ = value;
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06007ACB RID: 31435 RVA: 0x00145272 File Offset: 0x00143472
		// (set) Token: 0x06007ACC RID: 31436 RVA: 0x0014527A File Offset: 0x0014347A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FALLAINIGJD
		{
			get
			{
				return this.fALLAINIGJD_;
			}
			set
			{
				this.fALLAINIGJD_ = value;
			}
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x00145283 File Offset: 0x00143483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MGLKKPJKBLJ);
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x00145291 File Offset: 0x00143491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MGLKKPJKBLJ other)
		{
			return other != null && (other == this || (this.GGEPGHPENFG == other.GGEPGHPENFG && this.FALLAINIGJD == other.FALLAINIGJD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x001452D0 File Offset: 0x001434D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GGEPGHPENFG != 0U)
			{
				num ^= this.GGEPGHPENFG.GetHashCode();
			}
			if (this.FALLAINIGJD != 0U)
			{
				num ^= this.FALLAINIGJD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x00145328 File Offset: 0x00143528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x00145330 File Offset: 0x00143530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0014533C File Offset: 0x0014353C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FALLAINIGJD != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.FALLAINIGJD);
			}
			if (this.GGEPGHPENFG != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GGEPGHPENFG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x00145394 File Offset: 0x00143594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GGEPGHPENFG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GGEPGHPENFG);
			}
			if (this.FALLAINIGJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FALLAINIGJD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x001453EC File Offset: 0x001435EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MGLKKPJKBLJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GGEPGHPENFG != 0U)
			{
				this.GGEPGHPENFG = other.GGEPGHPENFG;
			}
			if (other.FALLAINIGJD != 0U)
			{
				this.FALLAINIGJD = other.FALLAINIGJD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x0014543C File Offset: 0x0014363C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x00145448 File Offset: 0x00143648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GGEPGHPENFG = input.ReadUInt32();
					}
				}
				else
				{
					this.FALLAINIGJD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002F1E RID: 12062
		private static readonly MessageParser<MGLKKPJKBLJ> _parser = new MessageParser<MGLKKPJKBLJ>(() => new MGLKKPJKBLJ());

		// Token: 0x04002F1F RID: 12063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F20 RID: 12064
		public const int GGEPGHPENFGFieldNumber = 6;

		// Token: 0x04002F21 RID: 12065
		private uint gGEPGHPENFG_;

		// Token: 0x04002F22 RID: 12066
		public const int FALLAINIGJDFieldNumber = 1;

		// Token: 0x04002F23 RID: 12067
		private uint fALLAINIGJD_;
	}
}
