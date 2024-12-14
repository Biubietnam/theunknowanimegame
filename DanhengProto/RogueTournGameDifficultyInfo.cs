using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FBF RID: 4031
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGameDifficultyInfo : IMessage<RogueTournGameDifficultyInfo>, IMessage, IEquatable<RogueTournGameDifficultyInfo>, IDeepCloneable<RogueTournGameDifficultyInfo>, IBufferMessage
	{
		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600B39D RID: 45981 RVA: 0x001E2685 File Offset: 0x001E0885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGameDifficultyInfo> Parser
		{
			get
			{
				return RogueTournGameDifficultyInfo._parser;
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600B39E RID: 45982 RVA: 0x001E268C File Offset: 0x001E088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGameDifficultyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600B39F RID: 45983 RVA: 0x001E269E File Offset: 0x001E089E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGameDifficultyInfo.Descriptor;
			}
		}

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x001E26A5 File Offset: 0x001E08A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameDifficultyInfo()
		{
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x001E26B8 File Offset: 0x001E08B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameDifficultyInfo(RogueTournGameDifficultyInfo other) : this()
		{
			this.difficultyIdList_ = other.difficultyIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x001E26E2 File Offset: 0x001E08E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameDifficultyInfo Clone()
		{
			return new RogueTournGameDifficultyInfo(this);
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600B3A3 RID: 45987 RVA: 0x001E26EA File Offset: 0x001E08EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DifficultyIdList
		{
			get
			{
				return this.difficultyIdList_;
			}
		}

		// Token: 0x0600B3A4 RID: 45988 RVA: 0x001E26F2 File Offset: 0x001E08F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGameDifficultyInfo);
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x001E2700 File Offset: 0x001E0900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGameDifficultyInfo other)
		{
			return other != null && (other == this || (this.difficultyIdList_.Equals(other.difficultyIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x001E2734 File Offset: 0x001E0934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.difficultyIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x001E2768 File Offset: 0x001E0968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x001E2770 File Offset: 0x001E0970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x001E2779 File Offset: 0x001E0979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.difficultyIdList_.WriteTo(ref output, RogueTournGameDifficultyInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x001E27A0 File Offset: 0x001E09A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.difficultyIdList_.CalculateSize(RogueTournGameDifficultyInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x001E27D9 File Offset: 0x001E09D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGameDifficultyInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.difficultyIdList_.Add(other.difficultyIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3AC RID: 45996 RVA: 0x001E2807 File Offset: 0x001E0A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3AD RID: 45997 RVA: 0x001E2810 File Offset: 0x001E0A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.difficultyIdList_.AddEntriesFrom(ref input, RogueTournGameDifficultyInfo._repeated_difficultyIdList_codec);
				}
			}
		}

		// Token: 0x040048E6 RID: 18662
		private static readonly MessageParser<RogueTournGameDifficultyInfo> _parser = new MessageParser<RogueTournGameDifficultyInfo>(() => new RogueTournGameDifficultyInfo());

		// Token: 0x040048E7 RID: 18663
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048E8 RID: 18664
		public const int DifficultyIdListFieldNumber = 6;

		// Token: 0x040048E9 RID: 18665
		private static readonly FieldCodec<uint> _repeated_difficultyIdList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x040048EA RID: 18666
		private readonly RepeatedField<uint> difficultyIdList_ = new RepeatedField<uint>();
	}
}
