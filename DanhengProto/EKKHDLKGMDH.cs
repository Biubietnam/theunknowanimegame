using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000409 RID: 1033
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EKKHDLKGMDH : IMessage<EKKHDLKGMDH>, IMessage, IEquatable<EKKHDLKGMDH>, IDeepCloneable<EKKHDLKGMDH>, IBufferMessage
	{
		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x0007EBDD File Offset: 0x0007CDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EKKHDLKGMDH> Parser
		{
			get
			{
				return EKKHDLKGMDH._parser;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x0007EBE4 File Offset: 0x0007CDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EKKHDLKGMDHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x0007EBF6 File Offset: 0x0007CDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EKKHDLKGMDH.Descriptor;
			}
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x0007EBFD File Offset: 0x0007CDFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EKKHDLKGMDH()
		{
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x0007EC08 File Offset: 0x0007CE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EKKHDLKGMDH(EKKHDLKGMDH other) : this()
		{
			this.oHODIEKBIKF_ = other.oHODIEKBIKF_;
			this.miracleInfo_ = ((other.miracleInfo_ != null) ? other.miracleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x0007EC54 File Offset: 0x0007CE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EKKHDLKGMDH Clone()
		{
			return new EKKHDLKGMDH(this);
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x0007EC5C File Offset: 0x0007CE5C
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x0007EC64 File Offset: 0x0007CE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OHODIEKBIKF
		{
			get
			{
				return this.oHODIEKBIKF_;
			}
			set
			{
				this.oHODIEKBIKF_ = value;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x0007EC6D File Offset: 0x0007CE6D
		// (set) Token: 0x06002DDE RID: 11742 RVA: 0x0007EC75 File Offset: 0x0007CE75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle MiracleInfo
		{
			get
			{
				return this.miracleInfo_;
			}
			set
			{
				this.miracleInfo_ = value;
			}
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0007EC7E File Offset: 0x0007CE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EKKHDLKGMDH);
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x0007EC8C File Offset: 0x0007CE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EKKHDLKGMDH other)
		{
			return other != null && (other == this || (this.OHODIEKBIKF == other.OHODIEKBIKF && object.Equals(this.MiracleInfo, other.MiracleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x0007ECDC File Offset: 0x0007CEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OHODIEKBIKF != 0U)
			{
				num ^= this.OHODIEKBIKF.GetHashCode();
			}
			if (this.miracleInfo_ != null)
			{
				num ^= this.MiracleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0007ED31 File Offset: 0x0007CF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x0007ED39 File Offset: 0x0007CF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x0007ED44 File Offset: 0x0007CF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OHODIEKBIKF != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.OHODIEKBIKF);
			}
			if (this.miracleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x0007EDA0 File Offset: 0x0007CFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OHODIEKBIKF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OHODIEKBIKF);
			}
			if (this.miracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x0007EDF8 File Offset: 0x0007CFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EKKHDLKGMDH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OHODIEKBIKF != 0U)
			{
				this.OHODIEKBIKF = other.OHODIEKBIKF;
			}
			if (other.miracleInfo_ != null)
			{
				if (this.miracleInfo_ == null)
				{
					this.MiracleInfo = new GameRogueMiracle();
				}
				this.MiracleInfo.MergeFrom(other.MiracleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x0007EE60 File Offset: 0x0007D060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0007EE6C File Offset: 0x0007D06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.miracleInfo_ == null)
						{
							this.MiracleInfo = new GameRogueMiracle();
						}
						input.ReadMessage(this.MiracleInfo);
					}
				}
				else
				{
					this.OHODIEKBIKF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001270 RID: 4720
		private static readonly MessageParser<EKKHDLKGMDH> _parser = new MessageParser<EKKHDLKGMDH>(() => new EKKHDLKGMDH());

		// Token: 0x04001271 RID: 4721
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001272 RID: 4722
		public const int OHODIEKBIKFFieldNumber = 13;

		// Token: 0x04001273 RID: 4723
		private uint oHODIEKBIKF_;

		// Token: 0x04001274 RID: 4724
		public const int MiracleInfoFieldNumber = 14;

		// Token: 0x04001275 RID: 4725
		private GameRogueMiracle miracleInfo_;
	}
}
