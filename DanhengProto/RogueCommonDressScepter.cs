using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E4F RID: 3663
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDressScepter : IMessage<RogueCommonDressScepter>, IMessage, IEquatable<RogueCommonDressScepter>, IDeepCloneable<RogueCommonDressScepter>, IBufferMessage
	{
		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0600A36D RID: 41837 RVA: 0x001B7BCB File Offset: 0x001B5DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDressScepter> Parser
		{
			get
			{
				return RogueCommonDressScepter._parser;
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0600A36E RID: 41838 RVA: 0x001B7BD2 File Offset: 0x001B5DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDressScepterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0600A36F RID: 41839 RVA: 0x001B7BE4 File Offset: 0x001B5DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDressScepter.Descriptor;
			}
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x001B7BEB File Offset: 0x001B5DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDressScepter()
		{
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x001B7BF3 File Offset: 0x001B5DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDressScepter(RogueCommonDressScepter other) : this()
		{
			this.updateScepterInfo_ = ((other.updateScepterInfo_ != null) ? other.updateScepterInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x001B7C28 File Offset: 0x001B5E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDressScepter Clone()
		{
			return new RogueCommonDressScepter(this);
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x001B7C30 File Offset: 0x001B5E30
		// (set) Token: 0x0600A374 RID: 41844 RVA: 0x001B7C38 File Offset: 0x001B5E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameScepterInfo UpdateScepterInfo
		{
			get
			{
				return this.updateScepterInfo_;
			}
			set
			{
				this.updateScepterInfo_ = value;
			}
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x001B7C41 File Offset: 0x001B5E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDressScepter);
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x001B7C4F File Offset: 0x001B5E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDressScepter other)
		{
			return other != null && (other == this || (object.Equals(this.UpdateScepterInfo, other.UpdateScepterInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A377 RID: 41847 RVA: 0x001B7C84 File Offset: 0x001B5E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.updateScepterInfo_ != null)
			{
				num ^= this.UpdateScepterInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x001B7CC0 File Offset: 0x001B5EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x001B7CC8 File Offset: 0x001B5EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A37A RID: 41850 RVA: 0x001B7CD1 File Offset: 0x001B5ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.updateScepterInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.UpdateScepterInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x001B7D04 File Offset: 0x001B5F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.updateScepterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateScepterInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x001B7D44 File Offset: 0x001B5F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDressScepter other)
		{
			if (other == null)
			{
				return;
			}
			if (other.updateScepterInfo_ != null)
			{
				if (this.updateScepterInfo_ == null)
				{
					this.UpdateScepterInfo = new RogueMagicGameScepterInfo();
				}
				this.UpdateScepterInfo.MergeFrom(other.UpdateScepterInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x001B7D98 File Offset: 0x001B5F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x001B7DA4 File Offset: 0x001B5FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.updateScepterInfo_ == null)
					{
						this.UpdateScepterInfo = new RogueMagicGameScepterInfo();
					}
					input.ReadMessage(this.UpdateScepterInfo);
				}
			}
		}

		// Token: 0x040042EF RID: 17135
		private static readonly MessageParser<RogueCommonDressScepter> _parser = new MessageParser<RogueCommonDressScepter>(() => new RogueCommonDressScepter());

		// Token: 0x040042F0 RID: 17136
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042F1 RID: 17137
		public const int UpdateScepterInfoFieldNumber = 15;

		// Token: 0x040042F2 RID: 17138
		private RogueMagicGameScepterInfo updateScepterInfo_;
	}
}
