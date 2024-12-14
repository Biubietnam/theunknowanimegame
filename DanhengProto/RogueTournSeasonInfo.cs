using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001015 RID: 4117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournSeasonInfo : IMessage<RogueTournSeasonInfo>, IMessage, IEquatable<RogueTournSeasonInfo>, IDeepCloneable<RogueTournSeasonInfo>, IBufferMessage
	{
		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600B724 RID: 46884 RVA: 0x001EB6C5 File Offset: 0x001E98C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournSeasonInfo> Parser
		{
			get
			{
				return RogueTournSeasonInfo._parser;
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600B725 RID: 46885 RVA: 0x001EB6CC File Offset: 0x001E98CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournSeasonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600B726 RID: 46886 RVA: 0x001EB6DE File Offset: 0x001E98DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournSeasonInfo.Descriptor;
			}
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x001EB6E5 File Offset: 0x001E98E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSeasonInfo()
		{
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x001EB6ED File Offset: 0x001E98ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSeasonInfo(RogueTournSeasonInfo other) : this()
		{
			this.subTournId_ = other.subTournId_;
			this.mainTournId_ = other.mainTournId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x001EB71E File Offset: 0x001E991E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSeasonInfo Clone()
		{
			return new RogueTournSeasonInfo(this);
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600B72A RID: 46890 RVA: 0x001EB726 File Offset: 0x001E9926
		// (set) Token: 0x0600B72B RID: 46891 RVA: 0x001EB72E File Offset: 0x001E992E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubTournId
		{
			get
			{
				return this.subTournId_;
			}
			set
			{
				this.subTournId_ = value;
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600B72C RID: 46892 RVA: 0x001EB737 File Offset: 0x001E9937
		// (set) Token: 0x0600B72D RID: 46893 RVA: 0x001EB73F File Offset: 0x001E993F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainTournId
		{
			get
			{
				return this.mainTournId_;
			}
			set
			{
				this.mainTournId_ = value;
			}
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x001EB748 File Offset: 0x001E9948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournSeasonInfo);
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x001EB756 File Offset: 0x001E9956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournSeasonInfo other)
		{
			return other != null && (other == this || (this.SubTournId == other.SubTournId && this.MainTournId == other.MainTournId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x001EB794 File Offset: 0x001E9994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubTournId != 0U)
			{
				num ^= this.SubTournId.GetHashCode();
			}
			if (this.MainTournId != 0U)
			{
				num ^= this.MainTournId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x001EB7EC File Offset: 0x001E99EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x001EB7F4 File Offset: 0x001E99F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x001EB800 File Offset: 0x001E9A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainTournId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MainTournId);
			}
			if (this.SubTournId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.SubTournId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x001EB85C File Offset: 0x001E9A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubTournId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubTournId);
			}
			if (this.MainTournId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainTournId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x001EB8B4 File Offset: 0x001E9AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournSeasonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubTournId != 0U)
			{
				this.SubTournId = other.SubTournId;
			}
			if (other.MainTournId != 0U)
			{
				this.MainTournId = other.MainTournId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x001EB904 File Offset: 0x001E9B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x001EB910 File Offset: 0x001E9B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SubTournId = input.ReadUInt32();
					}
				}
				else
				{
					this.MainTournId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004A32 RID: 18994
		private static readonly MessageParser<RogueTournSeasonInfo> _parser = new MessageParser<RogueTournSeasonInfo>(() => new RogueTournSeasonInfo());

		// Token: 0x04004A33 RID: 18995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A34 RID: 18996
		public const int SubTournIdFieldNumber = 14;

		// Token: 0x04004A35 RID: 18997
		private uint subTournId_;

		// Token: 0x04004A36 RID: 18998
		public const int MainTournIdFieldNumber = 4;

		// Token: 0x04004A37 RID: 18999
		private uint mainTournId_;
	}
}
