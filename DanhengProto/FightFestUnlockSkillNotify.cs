using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200052F RID: 1327
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightFestUnlockSkillNotify : IMessage<FightFestUnlockSkillNotify>, IMessage, IEquatable<FightFestUnlockSkillNotify>, IDeepCloneable<FightFestUnlockSkillNotify>, IBufferMessage
	{
		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x000A3158 File Offset: 0x000A1358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFestUnlockSkillNotify> Parser
		{
			get
			{
				return FightFestUnlockSkillNotify._parser;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x000A315F File Offset: 0x000A135F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightFestUnlockSkillNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x000A3171 File Offset: 0x000A1371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFestUnlockSkillNotify.Descriptor;
			}
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x000A3178 File Offset: 0x000A1378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUnlockSkillNotify()
		{
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x000A3180 File Offset: 0x000A1380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUnlockSkillNotify(FightFestUnlockSkillNotify other) : this()
		{
			this.bHJCBBAGJJK_ = other.bHJCBBAGJJK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x000A31A5 File Offset: 0x000A13A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUnlockSkillNotify Clone()
		{
			return new FightFestUnlockSkillNotify(this);
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06003B53 RID: 15187 RVA: 0x000A31AD File Offset: 0x000A13AD
		// (set) Token: 0x06003B54 RID: 15188 RVA: 0x000A31B5 File Offset: 0x000A13B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BHJCBBAGJJK
		{
			get
			{
				return this.bHJCBBAGJJK_;
			}
			set
			{
				this.bHJCBBAGJJK_ = value;
			}
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000A31BE File Offset: 0x000A13BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFestUnlockSkillNotify);
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x000A31CC File Offset: 0x000A13CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFestUnlockSkillNotify other)
		{
			return other != null && (other == this || (this.BHJCBBAGJJK == other.BHJCBBAGJJK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x000A31FC File Offset: 0x000A13FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BHJCBBAGJJK != 0U)
			{
				num ^= this.BHJCBBAGJJK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x000A323B File Offset: 0x000A143B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x000A3243 File Offset: 0x000A1443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000A324C File Offset: 0x000A144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BHJCBBAGJJK != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BHJCBBAGJJK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000A3280 File Offset: 0x000A1480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BHJCBBAGJJK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BHJCBBAGJJK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x000A32BE File Offset: 0x000A14BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightFestUnlockSkillNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BHJCBBAGJJK != 0U)
			{
				this.BHJCBBAGJJK = other.BHJCBBAGJJK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x000A32EF File Offset: 0x000A14EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x000A32F8 File Offset: 0x000A14F8
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
					this.BHJCBBAGJJK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040017DF RID: 6111
		private static readonly MessageParser<FightFestUnlockSkillNotify> _parser = new MessageParser<FightFestUnlockSkillNotify>(() => new FightFestUnlockSkillNotify());

		// Token: 0x040017E0 RID: 6112
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017E1 RID: 6113
		public const int BHJCBBAGJJKFieldNumber = 5;

		// Token: 0x040017E2 RID: 6114
		private uint bHJCBBAGJJK_;
	}
}
