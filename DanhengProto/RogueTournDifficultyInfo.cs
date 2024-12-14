using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F99 RID: 3993
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournDifficultyInfo : IMessage<RogueTournDifficultyInfo>, IMessage, IEquatable<RogueTournDifficultyInfo>, IDeepCloneable<RogueTournDifficultyInfo>, IBufferMessage
	{
		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600B1E9 RID: 45545 RVA: 0x001DE421 File Offset: 0x001DC621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournDifficultyInfo> Parser
		{
			get
			{
				return RogueTournDifficultyInfo._parser;
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600B1EA RID: 45546 RVA: 0x001DE428 File Offset: 0x001DC628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournDifficultyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600B1EB RID: 45547 RVA: 0x001DE43A File Offset: 0x001DC63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournDifficultyInfo.Descriptor;
			}
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x001DE441 File Offset: 0x001DC641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDifficultyInfo()
		{
		}

		// Token: 0x0600B1ED RID: 45549 RVA: 0x001DE449 File Offset: 0x001DC649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDifficultyInfo(RogueTournDifficultyInfo other) : this()
		{
			this.difficultyId_ = other.difficultyId_;
			this.isUnlocked_ = other.isUnlocked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x001DE47A File Offset: 0x001DC67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDifficultyInfo Clone()
		{
			return new RogueTournDifficultyInfo(this);
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x001DE482 File Offset: 0x001DC682
		// (set) Token: 0x0600B1F0 RID: 45552 RVA: 0x001DE48A File Offset: 0x001DC68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DifficultyId
		{
			get
			{
				return this.difficultyId_;
			}
			set
			{
				this.difficultyId_ = value;
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x001DE493 File Offset: 0x001DC693
		// (set) Token: 0x0600B1F2 RID: 45554 RVA: 0x001DE49B File Offset: 0x001DC69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlocked
		{
			get
			{
				return this.isUnlocked_;
			}
			set
			{
				this.isUnlocked_ = value;
			}
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x001DE4A4 File Offset: 0x001DC6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournDifficultyInfo);
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x001DE4B2 File Offset: 0x001DC6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournDifficultyInfo other)
		{
			return other != null && (other == this || (this.DifficultyId == other.DifficultyId && this.IsUnlocked == other.IsUnlocked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x001DE4F0 File Offset: 0x001DC6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DifficultyId != 0U)
			{
				num ^= this.DifficultyId.GetHashCode();
			}
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x001DE548 File Offset: 0x001DC748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x001DE550 File Offset: 0x001DC750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x001DE55C File Offset: 0x001DC75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DifficultyId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.DifficultyId);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsUnlocked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x001DE5B8 File Offset: 0x001DC7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DifficultyId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DifficultyId);
			}
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x001DE604 File Offset: 0x001DC804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournDifficultyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DifficultyId != 0U)
			{
				this.DifficultyId = other.DifficultyId;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x001DE654 File Offset: 0x001DC854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x001DE660 File Offset: 0x001DC860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsUnlocked = input.ReadBool();
					}
				}
				else
				{
					this.DifficultyId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400485C RID: 18524
		private static readonly MessageParser<RogueTournDifficultyInfo> _parser = new MessageParser<RogueTournDifficultyInfo>(() => new RogueTournDifficultyInfo());

		// Token: 0x0400485D RID: 18525
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400485E RID: 18526
		public const int DifficultyIdFieldNumber = 7;

		// Token: 0x0400485F RID: 18527
		private uint difficultyId_;

		// Token: 0x04004860 RID: 18528
		public const int IsUnlockedFieldNumber = 15;

		// Token: 0x04004861 RID: 18529
		private bool isUnlocked_;
	}
}
