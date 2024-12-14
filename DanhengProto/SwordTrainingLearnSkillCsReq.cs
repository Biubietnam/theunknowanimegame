using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001235 RID: 4661
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingLearnSkillCsReq : IMessage<SwordTrainingLearnSkillCsReq>, IMessage, IEquatable<SwordTrainingLearnSkillCsReq>, IDeepCloneable<SwordTrainingLearnSkillCsReq>, IBufferMessage
	{
		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0600D035 RID: 53301 RVA: 0x0022DAFC File Offset: 0x0022BCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingLearnSkillCsReq> Parser
		{
			get
			{
				return SwordTrainingLearnSkillCsReq._parser;
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0600D036 RID: 53302 RVA: 0x0022DB03 File Offset: 0x0022BD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingLearnSkillCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0600D037 RID: 53303 RVA: 0x0022DB15 File Offset: 0x0022BD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingLearnSkillCsReq.Descriptor;
			}
		}

		// Token: 0x0600D038 RID: 53304 RVA: 0x0022DB1C File Offset: 0x0022BD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingLearnSkillCsReq()
		{
		}

		// Token: 0x0600D039 RID: 53305 RVA: 0x0022DB24 File Offset: 0x0022BD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingLearnSkillCsReq(SwordTrainingLearnSkillCsReq other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D03A RID: 53306 RVA: 0x0022DB49 File Offset: 0x0022BD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingLearnSkillCsReq Clone()
		{
			return new SwordTrainingLearnSkillCsReq(this);
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0600D03B RID: 53307 RVA: 0x0022DB51 File Offset: 0x0022BD51
		// (set) Token: 0x0600D03C RID: 53308 RVA: 0x0022DB59 File Offset: 0x0022BD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x0600D03D RID: 53309 RVA: 0x0022DB62 File Offset: 0x0022BD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingLearnSkillCsReq);
		}

		// Token: 0x0600D03E RID: 53310 RVA: 0x0022DB70 File Offset: 0x0022BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingLearnSkillCsReq other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D03F RID: 53311 RVA: 0x0022DBA0 File Offset: 0x0022BDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D040 RID: 53312 RVA: 0x0022DBDF File Offset: 0x0022BDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D041 RID: 53313 RVA: 0x0022DBE7 File Offset: 0x0022BDE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D042 RID: 53314 RVA: 0x0022DBF0 File Offset: 0x0022BDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D043 RID: 53315 RVA: 0x0022DC24 File Offset: 0x0022BE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D044 RID: 53316 RVA: 0x0022DC62 File Offset: 0x0022BE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingLearnSkillCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D045 RID: 53317 RVA: 0x0022DC93 File Offset: 0x0022BE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D046 RID: 53318 RVA: 0x0022DC9C File Offset: 0x0022BE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053B8 RID: 21432
		private static readonly MessageParser<SwordTrainingLearnSkillCsReq> _parser = new MessageParser<SwordTrainingLearnSkillCsReq>(() => new SwordTrainingLearnSkillCsReq());

		// Token: 0x040053B9 RID: 21433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053BA RID: 21434
		public const int SkillIdFieldNumber = 4;

		// Token: 0x040053BB RID: 21435
		private uint skillId_;
	}
}
