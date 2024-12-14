using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B11 RID: 2833
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyCheatDiceCsReq : IMessage<MonopolyCheatDiceCsReq>, IMessage, IEquatable<MonopolyCheatDiceCsReq>, IDeepCloneable<MonopolyCheatDiceCsReq>, IBufferMessage
	{
		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x06007D69 RID: 32105 RVA: 0x0014C03C File Offset: 0x0014A23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyCheatDiceCsReq> Parser
		{
			get
			{
				return MonopolyCheatDiceCsReq._parser;
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x0014C043 File Offset: 0x0014A243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyCheatDiceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x06007D6B RID: 32107 RVA: 0x0014C055 File Offset: 0x0014A255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyCheatDiceCsReq.Descriptor;
			}
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x0014C05C File Offset: 0x0014A25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCheatDiceCsReq()
		{
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x0014C064 File Offset: 0x0014A264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCheatDiceCsReq(MonopolyCheatDiceCsReq other) : this()
		{
			this.mGPAHNMBAMI_ = other.mGPAHNMBAMI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D6E RID: 32110 RVA: 0x0014C089 File Offset: 0x0014A289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyCheatDiceCsReq Clone()
		{
			return new MonopolyCheatDiceCsReq(this);
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x06007D6F RID: 32111 RVA: 0x0014C091 File Offset: 0x0014A291
		// (set) Token: 0x06007D70 RID: 32112 RVA: 0x0014C099 File Offset: 0x0014A299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGPAHNMBAMI
		{
			get
			{
				return this.mGPAHNMBAMI_;
			}
			set
			{
				this.mGPAHNMBAMI_ = value;
			}
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x0014C0A2 File Offset: 0x0014A2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyCheatDiceCsReq);
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x0014C0B0 File Offset: 0x0014A2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyCheatDiceCsReq other)
		{
			return other != null && (other == this || (this.MGPAHNMBAMI == other.MGPAHNMBAMI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x0014C0E0 File Offset: 0x0014A2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MGPAHNMBAMI != 0U)
			{
				num ^= this.MGPAHNMBAMI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x0014C11F File Offset: 0x0014A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x0014C127 File Offset: 0x0014A327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x0014C130 File Offset: 0x0014A330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGPAHNMBAMI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MGPAHNMBAMI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x0014C164 File Offset: 0x0014A364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MGPAHNMBAMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGPAHNMBAMI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x0014C1A2 File Offset: 0x0014A3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyCheatDiceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MGPAHNMBAMI != 0U)
			{
				this.MGPAHNMBAMI = other.MGPAHNMBAMI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D79 RID: 32121 RVA: 0x0014C1D3 File Offset: 0x0014A3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D7A RID: 32122 RVA: 0x0014C1DC File Offset: 0x0014A3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MGPAHNMBAMI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003030 RID: 12336
		private static readonly MessageParser<MonopolyCheatDiceCsReq> _parser = new MessageParser<MonopolyCheatDiceCsReq>(() => new MonopolyCheatDiceCsReq());

		// Token: 0x04003031 RID: 12337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003032 RID: 12338
		public const int MGPAHNMBAMIFieldNumber = 5;

		// Token: 0x04003033 RID: 12339
		private uint mGPAHNMBAMI_;
	}
}
