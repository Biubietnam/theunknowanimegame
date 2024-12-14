using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000367 RID: 871
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeactivateFarmElementScRsp : IMessage<DeactivateFarmElementScRsp>, IMessage, IEquatable<DeactivateFarmElementScRsp>, IDeepCloneable<DeactivateFarmElementScRsp>, IBufferMessage
	{
		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x0006CC91 File Offset: 0x0006AE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeactivateFarmElementScRsp> Parser
		{
			get
			{
				return DeactivateFarmElementScRsp._parser;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x0006CC98 File Offset: 0x0006AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeactivateFarmElementScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x0006CCAA File Offset: 0x0006AEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeactivateFarmElementScRsp.Descriptor;
			}
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x0006CCB1 File Offset: 0x0006AEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeactivateFarmElementScRsp()
		{
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0006CCB9 File Offset: 0x0006AEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeactivateFarmElementScRsp(DeactivateFarmElementScRsp other) : this()
		{
			this.entityId_ = other.entityId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0006CCEA File Offset: 0x0006AEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeactivateFarmElementScRsp Clone()
		{
			return new DeactivateFarmElementScRsp(this);
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x0006CCF2 File Offset: 0x0006AEF2
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0006CCFA File Offset: 0x0006AEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x0006CD03 File Offset: 0x0006AF03
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x0006CD0B File Offset: 0x0006AF0B
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

		// Token: 0x060026E3 RID: 9955 RVA: 0x0006CD14 File Offset: 0x0006AF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeactivateFarmElementScRsp);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0006CD22 File Offset: 0x0006AF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeactivateFarmElementScRsp other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0006CD60 File Offset: 0x0006AF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
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

		// Token: 0x060026E6 RID: 9958 RVA: 0x0006CDB8 File Offset: 0x0006AFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0006CDC0 File Offset: 0x0006AFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0006CDCC File Offset: 0x0006AFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EntityId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0006CE24 File Offset: 0x0006B024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
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

		// Token: 0x060026EA RID: 9962 RVA: 0x0006CE7C File Offset: 0x0006B07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeactivateFarmElementScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x0006CECC File Offset: 0x0006B0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0006CED8 File Offset: 0x0006B0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 64U)
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
					this.EntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000FB1 RID: 4017
		private static readonly MessageParser<DeactivateFarmElementScRsp> _parser = new MessageParser<DeactivateFarmElementScRsp>(() => new DeactivateFarmElementScRsp());

		// Token: 0x04000FB2 RID: 4018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FB3 RID: 4019
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04000FB4 RID: 4020
		private uint entityId_;

		// Token: 0x04000FB5 RID: 4021
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04000FB6 RID: 4022
		private uint retcode_;
	}
}
