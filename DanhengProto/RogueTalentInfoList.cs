using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F7B RID: 3963
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTalentInfoList : IMessage<RogueTalentInfoList>, IMessage, IEquatable<RogueTalentInfoList>, IDeepCloneable<RogueTalentInfoList>, IBufferMessage
	{
		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600B08D RID: 45197 RVA: 0x001DA529 File Offset: 0x001D8729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTalentInfoList> Parser
		{
			get
			{
				return RogueTalentInfoList._parser;
			}
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600B08E RID: 45198 RVA: 0x001DA530 File Offset: 0x001D8730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTalentInfoListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600B08F RID: 45199 RVA: 0x001DA542 File Offset: 0x001D8742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTalentInfoList.Descriptor;
			}
		}

		// Token: 0x0600B090 RID: 45200 RVA: 0x001DA549 File Offset: 0x001D8749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfoList()
		{
		}

		// Token: 0x0600B091 RID: 45201 RVA: 0x001DA55C File Offset: 0x001D875C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfoList(RogueTalentInfoList other) : this()
		{
			this.talentInfo_ = other.talentInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B092 RID: 45202 RVA: 0x001DA586 File Offset: 0x001D8786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfoList Clone()
		{
			return new RogueTalentInfoList(this);
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600B093 RID: 45203 RVA: 0x001DA58E File Offset: 0x001D878E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTalentInfo> TalentInfo
		{
			get
			{
				return this.talentInfo_;
			}
		}

		// Token: 0x0600B094 RID: 45204 RVA: 0x001DA596 File Offset: 0x001D8796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTalentInfoList);
		}

		// Token: 0x0600B095 RID: 45205 RVA: 0x001DA5A4 File Offset: 0x001D87A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTalentInfoList other)
		{
			return other != null && (other == this || (this.talentInfo_.Equals(other.talentInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x001DA5D8 File Offset: 0x001D87D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.talentInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B097 RID: 45207 RVA: 0x001DA60C File Offset: 0x001D880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B098 RID: 45208 RVA: 0x001DA614 File Offset: 0x001D8814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B099 RID: 45209 RVA: 0x001DA61D File Offset: 0x001D881D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talentInfo_.WriteTo(ref output, RogueTalentInfoList._repeated_talentInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B09A RID: 45210 RVA: 0x001DA644 File Offset: 0x001D8844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.talentInfo_.CalculateSize(RogueTalentInfoList._repeated_talentInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B09B RID: 45211 RVA: 0x001DA67D File Offset: 0x001D887D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTalentInfoList other)
		{
			if (other == null)
			{
				return;
			}
			this.talentInfo_.Add(other.talentInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B09C RID: 45212 RVA: 0x001DA6AB File Offset: 0x001D88AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B09D RID: 45213 RVA: 0x001DA6B4 File Offset: 0x001D88B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.talentInfo_.AddEntriesFrom(ref input, RogueTalentInfoList._repeated_talentInfo_codec);
				}
			}
		}

		// Token: 0x040047D5 RID: 18389
		private static readonly MessageParser<RogueTalentInfoList> _parser = new MessageParser<RogueTalentInfoList>(() => new RogueTalentInfoList());

		// Token: 0x040047D6 RID: 18390
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047D7 RID: 18391
		public const int TalentInfoFieldNumber = 8;

		// Token: 0x040047D8 RID: 18392
		private static readonly FieldCodec<RogueTalentInfo> _repeated_talentInfo_codec = FieldCodec.ForMessage<RogueTalentInfo>(66U, RogueTalentInfo.Parser);

		// Token: 0x040047D9 RID: 18393
		private readonly RepeatedField<RogueTalentInfo> talentInfo_ = new RepeatedField<RogueTalentInfo>();
	}
}
