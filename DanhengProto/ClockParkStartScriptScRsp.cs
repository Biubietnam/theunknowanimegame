using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002FF RID: 767
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkStartScriptScRsp : IMessage<ClockParkStartScriptScRsp>, IMessage, IEquatable<ClockParkStartScriptScRsp>, IDeepCloneable<ClockParkStartScriptScRsp>, IBufferMessage
	{
		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x00061959 File Offset: 0x0005FB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkStartScriptScRsp> Parser
		{
			get
			{
				return ClockParkStartScriptScRsp._parser;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00061960 File Offset: 0x0005FB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkStartScriptScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x00061972 File Offset: 0x0005FB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkStartScriptScRsp.Descriptor;
			}
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00061979 File Offset: 0x0005FB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkStartScriptScRsp()
		{
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00061981 File Offset: 0x0005FB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkStartScriptScRsp(ClockParkStartScriptScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.scriptId_ = other.scriptId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x000619B2 File Offset: 0x0005FBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkStartScriptScRsp Clone()
		{
			return new ClockParkStartScriptScRsp(this);
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x000619BA File Offset: 0x0005FBBA
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x000619C2 File Offset: 0x0005FBC2
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

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x000619CB File Offset: 0x0005FBCB
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x000619D3 File Offset: 0x0005FBD3
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

		// Token: 0x06002253 RID: 8787 RVA: 0x000619DC File Offset: 0x0005FBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkStartScriptScRsp);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x000619EA File Offset: 0x0005FBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkStartScriptScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.ScriptId == other.ScriptId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00061A28 File Offset: 0x0005FC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x06002256 RID: 8790 RVA: 0x00061A80 File Offset: 0x0005FC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00061A88 File Offset: 0x0005FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00061A94 File Offset: 0x0005FC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00061AF0 File Offset: 0x0005FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x0600225A RID: 8794 RVA: 0x00061B48 File Offset: 0x0005FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkStartScriptScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00061B98 File Offset: 0x0005FD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00061BA4 File Offset: 0x0005FDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ScriptId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000E28 RID: 3624
		private static readonly MessageParser<ClockParkStartScriptScRsp> _parser = new MessageParser<ClockParkStartScriptScRsp>(() => new ClockParkStartScriptScRsp());

		// Token: 0x04000E29 RID: 3625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E2A RID: 3626
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04000E2B RID: 3627
		private uint retcode_;

		// Token: 0x04000E2C RID: 3628
		public const int ScriptIdFieldNumber = 11;

		// Token: 0x04000E2D RID: 3629
		private uint scriptId_;
	}
}
