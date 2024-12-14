using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004C9 RID: 1225
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildStartStageCsReq : IMessage<EvolveBuildStartStageCsReq>, IMessage, IEquatable<EvolveBuildStartStageCsReq>, IDeepCloneable<EvolveBuildStartStageCsReq>, IBufferMessage
	{
		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x000968A4 File Offset: 0x00094AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildStartStageCsReq> Parser
		{
			get
			{
				return EvolveBuildStartStageCsReq._parser;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x000968AB File Offset: 0x00094AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildStartStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x000968BD File Offset: 0x00094ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildStartStageCsReq.Descriptor;
			}
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x000968C4 File Offset: 0x00094AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartStageCsReq()
		{
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x000968CC File Offset: 0x00094ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartStageCsReq(EvolveBuildStartStageCsReq other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x000968F1 File Offset: 0x00094AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartStageCsReq Clone()
		{
			return new EvolveBuildStartStageCsReq(this);
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x000968F9 File Offset: 0x00094AF9
		// (set) Token: 0x060036CC RID: 14028 RVA: 0x00096901 File Offset: 0x00094B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0009690A File Offset: 0x00094B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildStartStageCsReq);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00096918 File Offset: 0x00094B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildStartStageCsReq other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00096948 File Offset: 0x00094B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00096987 File Offset: 0x00094B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0009698F File Offset: 0x00094B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00096998 File Offset: 0x00094B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x000969CC File Offset: 0x00094BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00096A0A File Offset: 0x00094C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildStartStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00096A3B File Offset: 0x00094C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00096A44 File Offset: 0x00094C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015C4 RID: 5572
		private static readonly MessageParser<EvolveBuildStartStageCsReq> _parser = new MessageParser<EvolveBuildStartStageCsReq>(() => new EvolveBuildStartStageCsReq());

		// Token: 0x040015C5 RID: 5573
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015C6 RID: 5574
		public const int LevelIdFieldNumber = 3;

		// Token: 0x040015C7 RID: 5575
		private uint levelId_;
	}
}
