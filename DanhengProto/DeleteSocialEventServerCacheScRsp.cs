using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200037B RID: 891
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteSocialEventServerCacheScRsp : IMessage<DeleteSocialEventServerCacheScRsp>, IMessage, IEquatable<DeleteSocialEventServerCacheScRsp>, IDeepCloneable<DeleteSocialEventServerCacheScRsp>, IBufferMessage
	{
		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x0006E905 File Offset: 0x0006CB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteSocialEventServerCacheScRsp> Parser
		{
			get
			{
				return DeleteSocialEventServerCacheScRsp._parser;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x0006E90C File Offset: 0x0006CB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteSocialEventServerCacheScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x0006E91E File Offset: 0x0006CB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteSocialEventServerCacheScRsp.Descriptor;
			}
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x0006E925 File Offset: 0x0006CB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSocialEventServerCacheScRsp()
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0006E938 File Offset: 0x0006CB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSocialEventServerCacheScRsp(DeleteSocialEventServerCacheScRsp other) : this()
		{
			this.gINKEDBBKMP_ = other.gINKEDBBKMP_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x0006E96E File Offset: 0x0006CB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSocialEventServerCacheScRsp Clone()
		{
			return new DeleteSocialEventServerCacheScRsp(this);
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x0006E976 File Offset: 0x0006CB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GINKEDBBKMP
		{
			get
			{
				return this.gINKEDBBKMP_;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x0006E97E File Offset: 0x0006CB7E
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x0006E986 File Offset: 0x0006CB86
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

		// Token: 0x060027AC RID: 10156 RVA: 0x0006E98F File Offset: 0x0006CB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteSocialEventServerCacheScRsp);
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteSocialEventServerCacheScRsp other)
		{
			return other != null && (other == this || (this.gINKEDBBKMP_.Equals(other.gINKEDBBKMP_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x0006E9F0 File Offset: 0x0006CBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gINKEDBBKMP_.GetHashCode();
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

		// Token: 0x060027AF RID: 10159 RVA: 0x0006EA3D File Offset: 0x0006CC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x0006EA45 File Offset: 0x0006CC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x0006EA50 File Offset: 0x0006CC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gINKEDBBKMP_.WriteTo(ref output, DeleteSocialEventServerCacheScRsp._repeated_gINKEDBBKMP_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gINKEDBBKMP_.CalculateSize(DeleteSocialEventServerCacheScRsp._repeated_gINKEDBBKMP_codec);
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

		// Token: 0x060027B3 RID: 10163 RVA: 0x0006EAF4 File Offset: 0x0006CCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteSocialEventServerCacheScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.gINKEDBBKMP_.Add(other.gINKEDBBKMP_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x0006EB41 File Offset: 0x0006CD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0006EB4C File Offset: 0x0006CD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					if (num != 24U)
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
					this.gINKEDBBKMP_.AddEntriesFrom(ref input, DeleteSocialEventServerCacheScRsp._repeated_gINKEDBBKMP_codec);
				}
			}
		}

		// Token: 0x04000FF9 RID: 4089
		private static readonly MessageParser<DeleteSocialEventServerCacheScRsp> _parser = new MessageParser<DeleteSocialEventServerCacheScRsp>(() => new DeleteSocialEventServerCacheScRsp());

		// Token: 0x04000FFA RID: 4090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FFB RID: 4091
		public const int GINKEDBBKMPFieldNumber = 1;

		// Token: 0x04000FFC RID: 4092
		private static readonly FieldCodec<uint> _repeated_gINKEDBBKMP_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04000FFD RID: 4093
		private readonly RepeatedField<uint> gINKEDBBKMP_ = new RepeatedField<uint>();

		// Token: 0x04000FFE RID: 4094
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04000FFF RID: 4095
		private uint retcode_;
	}
}
