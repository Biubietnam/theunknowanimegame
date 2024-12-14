using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000269 RID: 617
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryAeon : IMessage<ChessRogueQueryAeon>, IMessage, IEquatable<ChessRogueQueryAeon>, IDeepCloneable<ChessRogueQueryAeon>, IBufferMessage
	{
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0004F49C File Offset: 0x0004D69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryAeon> Parser
		{
			get
			{
				return ChessRogueQueryAeon._parser;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0004F4A3 File Offset: 0x0004D6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryAeonReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0004F4B5 File Offset: 0x0004D6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryAeon.Descriptor;
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0004F4BC File Offset: 0x0004D6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeon()
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0004F4C4 File Offset: 0x0004D6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeon(ChessRogueQueryAeon other) : this()
		{
			this.hDDGPMMNICD_ = other.hDDGPMMNICD_;
			this.aeonId_ = other.aeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0004F4F5 File Offset: 0x0004D6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeon Clone()
		{
			return new ChessRogueQueryAeon(this);
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0004F4FD File Offset: 0x0004D6FD
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x0004F505 File Offset: 0x0004D705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDDGPMMNICD
		{
			get
			{
				return this.hDDGPMMNICD_;
			}
			set
			{
				this.hDDGPMMNICD_ = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0004F50E File Offset: 0x0004D70E
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x0004F516 File Offset: 0x0004D716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0004F51F File Offset: 0x0004D71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryAeon);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0004F52D File Offset: 0x0004D72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryAeon other)
		{
			return other != null && (other == this || (this.HDDGPMMNICD == other.HDDGPMMNICD && this.AeonId == other.AeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0004F56C File Offset: 0x0004D76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HDDGPMMNICD != 0U)
			{
				num ^= this.HDDGPMMNICD.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0004F5C4 File Offset: 0x0004D7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0004F5CC File Offset: 0x0004D7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AeonId);
			}
			if (this.HDDGPMMNICD != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.HDDGPMMNICD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0004F634 File Offset: 0x0004D834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HDDGPMMNICD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDDGPMMNICD);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0004F68C File Offset: 0x0004D88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryAeon other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HDDGPMMNICD != 0U)
			{
				this.HDDGPMMNICD = other.HDDGPMMNICD;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0004F6DC File Offset: 0x0004D8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0004F6E8 File Offset: 0x0004D8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HDDGPMMNICD = input.ReadUInt32();
					}
				}
				else
				{
					this.AeonId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000B97 RID: 2967
		private static readonly MessageParser<ChessRogueQueryAeon> _parser = new MessageParser<ChessRogueQueryAeon>(() => new ChessRogueQueryAeon());

		// Token: 0x04000B98 RID: 2968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B99 RID: 2969
		public const int HDDGPMMNICDFieldNumber = 12;

		// Token: 0x04000B9A RID: 2970
		private uint hDDGPMMNICD_;

		// Token: 0x04000B9B RID: 2971
		public const int AeonIdFieldNumber = 3;

		// Token: 0x04000B9C RID: 2972
		private uint aeonId_;
	}
}
