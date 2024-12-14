using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F5B RID: 3931
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModuleInfo : IMessage<RogueModuleInfo>, IMessage, IEquatable<RogueModuleInfo>, IDeepCloneable<RogueModuleInfo>, IBufferMessage
	{
		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x001D7000 File Offset: 0x001D5200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModuleInfo> Parser
		{
			get
			{
				return RogueModuleInfo._parser;
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600AF3F RID: 44863 RVA: 0x001D7007 File Offset: 0x001D5207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModuleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600AF40 RID: 44864 RVA: 0x001D7019 File Offset: 0x001D5219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModuleInfo.Descriptor;
			}
		}

		// Token: 0x0600AF41 RID: 44865 RVA: 0x001D7020 File Offset: 0x001D5220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModuleInfo()
		{
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x001D7033 File Offset: 0x001D5233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModuleInfo(RogueModuleInfo other) : this()
		{
			this.moduleIdList_ = other.moduleIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x001D705D File Offset: 0x001D525D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModuleInfo Clone()
		{
			return new RogueModuleInfo(this);
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600AF44 RID: 44868 RVA: 0x001D7065 File Offset: 0x001D5265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ModuleIdList
		{
			get
			{
				return this.moduleIdList_;
			}
		}

		// Token: 0x0600AF45 RID: 44869 RVA: 0x001D706D File Offset: 0x001D526D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModuleInfo);
		}

		// Token: 0x0600AF46 RID: 44870 RVA: 0x001D707B File Offset: 0x001D527B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModuleInfo other)
		{
			return other != null && (other == this || (this.moduleIdList_.Equals(other.moduleIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF47 RID: 44871 RVA: 0x001D70B0 File Offset: 0x001D52B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.moduleIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF48 RID: 44872 RVA: 0x001D70E4 File Offset: 0x001D52E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF49 RID: 44873 RVA: 0x001D70EC File Offset: 0x001D52EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF4A RID: 44874 RVA: 0x001D70F5 File Offset: 0x001D52F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.moduleIdList_.WriteTo(ref output, RogueModuleInfo._repeated_moduleIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF4B RID: 44875 RVA: 0x001D711C File Offset: 0x001D531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.moduleIdList_.CalculateSize(RogueModuleInfo._repeated_moduleIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF4C RID: 44876 RVA: 0x001D7155 File Offset: 0x001D5355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModuleInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.moduleIdList_.Add(other.moduleIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF4D RID: 44877 RVA: 0x001D7183 File Offset: 0x001D5383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF4E RID: 44878 RVA: 0x001D718C File Offset: 0x001D538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.moduleIdList_.AddEntriesFrom(ref input, RogueModuleInfo._repeated_moduleIdList_codec);
				}
			}
		}

		// Token: 0x0400474E RID: 18254
		private static readonly MessageParser<RogueModuleInfo> _parser = new MessageParser<RogueModuleInfo>(() => new RogueModuleInfo());

		// Token: 0x0400474F RID: 18255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004750 RID: 18256
		public const int ModuleIdListFieldNumber = 7;

		// Token: 0x04004751 RID: 18257
		private static readonly FieldCodec<uint> _repeated_moduleIdList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04004752 RID: 18258
		private readonly RepeatedField<uint> moduleIdList_ = new RepeatedField<uint>();
	}
}
