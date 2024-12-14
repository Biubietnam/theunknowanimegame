using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000019 RID: 25
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptMainMissionCsReq : IMessage<AcceptMainMissionCsReq>, IMessage, IEquatable<AcceptMainMissionCsReq>, IDeepCloneable<AcceptMainMissionCsReq>, IBufferMessage
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003EEC File Offset: 0x000020EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptMainMissionCsReq> Parser
		{
			get
			{
				return AcceptMainMissionCsReq._parser;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003EF3 File Offset: 0x000020F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptMainMissionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003F05 File Offset: 0x00002105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptMainMissionCsReq.Descriptor;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003F0C File Offset: 0x0000210C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMainMissionCsReq()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003F14 File Offset: 0x00002114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMainMissionCsReq(AcceptMainMissionCsReq other) : this()
		{
			this.mainMissionId_ = other.mainMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003F39 File Offset: 0x00002139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMainMissionCsReq Clone()
		{
			return new AcceptMainMissionCsReq(this);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003F41 File Offset: 0x00002141
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00003F49 File Offset: 0x00002149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003F52 File Offset: 0x00002152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptMainMissionCsReq);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003F60 File Offset: 0x00002160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptMainMissionCsReq other)
		{
			return other != null && (other == this || (this.MainMissionId == other.MainMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003F90 File Offset: 0x00002190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003FCF File Offset: 0x000021CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003FD7 File Offset: 0x000021D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003FE0 File Offset: 0x000021E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004014 File Offset: 0x00002214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004052 File Offset: 0x00002252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptMainMissionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004083 File Offset: 0x00002283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000408C File Offset: 0x0000228C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MainMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400004B RID: 75
		private static readonly MessageParser<AcceptMainMissionCsReq> _parser = new MessageParser<AcceptMainMissionCsReq>(() => new AcceptMainMissionCsReq());

		// Token: 0x0400004C RID: 76
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400004D RID: 77
		public const int MainMissionIdFieldNumber = 1;

		// Token: 0x0400004E RID: 78
		private uint mainMissionId_;
	}
}
