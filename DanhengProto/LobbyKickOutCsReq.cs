using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A45 RID: 2629
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyKickOutCsReq : IMessage<LobbyKickOutCsReq>, IMessage, IEquatable<LobbyKickOutCsReq>, IDeepCloneable<LobbyKickOutCsReq>, IBufferMessage
	{
		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x060074AC RID: 29868 RVA: 0x001363E4 File Offset: 0x001345E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyKickOutCsReq> Parser
		{
			get
			{
				return LobbyKickOutCsReq._parser;
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x060074AD RID: 29869 RVA: 0x001363EB File Offset: 0x001345EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyKickOutCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x060074AE RID: 29870 RVA: 0x001363FD File Offset: 0x001345FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyKickOutCsReq.Descriptor;
			}
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x00136404 File Offset: 0x00134604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyKickOutCsReq()
		{
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x0013640C File Offset: 0x0013460C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyKickOutCsReq(LobbyKickOutCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x00136431 File Offset: 0x00134631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyKickOutCsReq Clone()
		{
			return new LobbyKickOutCsReq(this);
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x060074B2 RID: 29874 RVA: 0x00136439 File Offset: 0x00134639
		// (set) Token: 0x060074B3 RID: 29875 RVA: 0x00136441 File Offset: 0x00134641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x0013644A File Offset: 0x0013464A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyKickOutCsReq);
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x00136458 File Offset: 0x00134658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyKickOutCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x00136488 File Offset: 0x00134688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x001364C7 File Offset: 0x001346C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x001364CF File Offset: 0x001346CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x001364D8 File Offset: 0x001346D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x0013650C File Offset: 0x0013470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x0013654A File Offset: 0x0013474A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyKickOutCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x0013657B File Offset: 0x0013477B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x00136584 File Offset: 0x00134784
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
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002CE2 RID: 11490
		private static readonly MessageParser<LobbyKickOutCsReq> _parser = new MessageParser<LobbyKickOutCsReq>(() => new LobbyKickOutCsReq());

		// Token: 0x04002CE3 RID: 11491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CE4 RID: 11492
		public const int UidFieldNumber = 5;

		// Token: 0x04002CE5 RID: 11493
		private uint uid_;
	}
}
