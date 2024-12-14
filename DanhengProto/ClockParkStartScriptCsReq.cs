using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002FD RID: 765
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkStartScriptCsReq : IMessage<ClockParkStartScriptCsReq>, IMessage, IEquatable<ClockParkStartScriptCsReq>, IDeepCloneable<ClockParkStartScriptCsReq>, IBufferMessage
	{
		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0006160D File Offset: 0x0005F80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkStartScriptCsReq> Parser
		{
			get
			{
				return ClockParkStartScriptCsReq._parser;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00061614 File Offset: 0x0005F814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkStartScriptCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00061626 File Offset: 0x0005F826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkStartScriptCsReq.Descriptor;
			}
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0006162D File Offset: 0x0005F82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkStartScriptCsReq()
		{
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00061640 File Offset: 0x0005F840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkStartScriptCsReq(ClockParkStartScriptCsReq other) : this()
		{
			this.scriptId_ = other.scriptId_;
			this.lICJMGLLFPO_ = other.lICJMGLLFPO_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00061676 File Offset: 0x0005F876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkStartScriptCsReq Clone()
		{
			return new ClockParkStartScriptCsReq(this);
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x0006167E File Offset: 0x0005F87E
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x00061686 File Offset: 0x0005F886
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

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0006168F File Offset: 0x0005F88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LICJMGLLFPO
		{
			get
			{
				return this.lICJMGLLFPO_;
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00061697 File Offset: 0x0005F897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkStartScriptCsReq);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x000616A8 File Offset: 0x0005F8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkStartScriptCsReq other)
		{
			return other != null && (other == this || (this.ScriptId == other.ScriptId && this.lICJMGLLFPO_.Equals(other.lICJMGLLFPO_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000616F8 File Offset: 0x0005F8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			num ^= this.lICJMGLLFPO_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00061745 File Offset: 0x0005F945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0006174D File Offset: 0x0005F94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00061758 File Offset: 0x0005F958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ScriptId);
			}
			this.lICJMGLLFPO_.WriteTo(ref output, ClockParkStartScriptCsReq._repeated_lICJMGLLFPO_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x000617A8 File Offset: 0x0005F9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			num += this.lICJMGLLFPO_.CalculateSize(ClockParkStartScriptCsReq._repeated_lICJMGLLFPO_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x000617FC File Offset: 0x0005F9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkStartScriptCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			this.lICJMGLLFPO_.Add(other.lICJMGLLFPO_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00061849 File Offset: 0x0005FA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00061854 File Offset: 0x0005FA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.lICJMGLLFPO_.AddEntriesFrom(ref input, ClockParkStartScriptCsReq._repeated_lICJMGLLFPO_codec);
					}
				}
				else
				{
					this.ScriptId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000E20 RID: 3616
		private static readonly MessageParser<ClockParkStartScriptCsReq> _parser = new MessageParser<ClockParkStartScriptCsReq>(() => new ClockParkStartScriptCsReq());

		// Token: 0x04000E21 RID: 3617
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E22 RID: 3618
		public const int ScriptIdFieldNumber = 11;

		// Token: 0x04000E23 RID: 3619
		private uint scriptId_;

		// Token: 0x04000E24 RID: 3620
		public const int LICJMGLLFPOFieldNumber = 14;

		// Token: 0x04000E25 RID: 3621
		private static readonly FieldCodec<uint> _repeated_lICJMGLLFPO_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04000E26 RID: 3622
		private readonly RepeatedField<uint> lICJMGLLFPO_ = new RepeatedField<uint>();
	}
}
