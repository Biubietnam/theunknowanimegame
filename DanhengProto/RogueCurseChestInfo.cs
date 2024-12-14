using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E6D RID: 3693
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCurseChestInfo : IMessage<RogueCurseChestInfo>, IMessage, IEquatable<RogueCurseChestInfo>, IDeepCloneable<RogueCurseChestInfo>, IBufferMessage
	{
		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x001BAF58 File Offset: 0x001B9158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCurseChestInfo> Parser
		{
			get
			{
				return RogueCurseChestInfo._parser;
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600A4C2 RID: 42178 RVA: 0x001BAF5F File Offset: 0x001B915F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCurseChestInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600A4C3 RID: 42179 RVA: 0x001BAF71 File Offset: 0x001B9171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCurseChestInfo.Descriptor;
			}
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x001BAF78 File Offset: 0x001B9178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurseChestInfo()
		{
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x001BAF80 File Offset: 0x001B9180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurseChestInfo(RogueCurseChestInfo other) : this()
		{
			this.curseChestId_ = other.curseChestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x001BAFA5 File Offset: 0x001B91A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurseChestInfo Clone()
		{
			return new RogueCurseChestInfo(this);
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600A4C7 RID: 42183 RVA: 0x001BAFAD File Offset: 0x001B91AD
		// (set) Token: 0x0600A4C8 RID: 42184 RVA: 0x001BAFB5 File Offset: 0x001B91B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurseChestId
		{
			get
			{
				return this.curseChestId_;
			}
			set
			{
				this.curseChestId_ = value;
			}
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x001BAFBE File Offset: 0x001B91BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCurseChestInfo);
		}

		// Token: 0x0600A4CA RID: 42186 RVA: 0x001BAFCC File Offset: 0x001B91CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCurseChestInfo other)
		{
			return other != null && (other == this || (this.CurseChestId == other.CurseChestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x001BAFFC File Offset: 0x001B91FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurseChestId != 0U)
			{
				num ^= this.CurseChestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x001BB03B File Offset: 0x001B923B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x001BB043 File Offset: 0x001B9243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x001BB04C File Offset: 0x001B924C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurseChestId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CurseChestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x001BB080 File Offset: 0x001B9280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurseChestId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurseChestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x001BB0BE File Offset: 0x001B92BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCurseChestInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurseChestId != 0U)
			{
				this.CurseChestId = other.CurseChestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x001BB0EF File Offset: 0x001B92EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x001BB0F8 File Offset: 0x001B92F8
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
					this.CurseChestId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004355 RID: 17237
		private static readonly MessageParser<RogueCurseChestInfo> _parser = new MessageParser<RogueCurseChestInfo>(() => new RogueCurseChestInfo());

		// Token: 0x04004356 RID: 17238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004357 RID: 17239
		public const int CurseChestIdFieldNumber = 1;

		// Token: 0x04004358 RID: 17240
		private uint curseChestId_;
	}
}
