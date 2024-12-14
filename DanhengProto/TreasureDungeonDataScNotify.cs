using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001397 RID: 5015
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureDungeonDataScNotify : IMessage<TreasureDungeonDataScNotify>, IMessage, IEquatable<TreasureDungeonDataScNotify>, IDeepCloneable<TreasureDungeonDataScNotify>, IBufferMessage
	{
		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x0600DFCA RID: 57290 RVA: 0x002536FD File Offset: 0x002518FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureDungeonDataScNotify> Parser
		{
			get
			{
				return TreasureDungeonDataScNotify._parser;
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x0600DFCB RID: 57291 RVA: 0x00253704 File Offset: 0x00251904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x0600DFCC RID: 57292 RVA: 0x00253716 File Offset: 0x00251916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureDungeonDataScNotify.Descriptor;
			}
		}

		// Token: 0x0600DFCD RID: 57293 RVA: 0x0025371D File Offset: 0x0025191D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonDataScNotify()
		{
		}

		// Token: 0x0600DFCE RID: 57294 RVA: 0x00253725 File Offset: 0x00251925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonDataScNotify(TreasureDungeonDataScNotify other) : this()
		{
			this.lHIECKPJNFD_ = ((other.lHIECKPJNFD_ != null) ? other.lHIECKPJNFD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFCF RID: 57295 RVA: 0x0025375A File Offset: 0x0025195A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonDataScNotify Clone()
		{
			return new TreasureDungeonDataScNotify(this);
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x0600DFD0 RID: 57296 RVA: 0x00253762 File Offset: 0x00251962
		// (set) Token: 0x0600DFD1 RID: 57297 RVA: 0x0025376A File Offset: 0x0025196A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonLevel LHIECKPJNFD
		{
			get
			{
				return this.lHIECKPJNFD_;
			}
			set
			{
				this.lHIECKPJNFD_ = value;
			}
		}

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x00253773 File Offset: 0x00251973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureDungeonDataScNotify);
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x00253781 File Offset: 0x00251981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureDungeonDataScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LHIECKPJNFD, other.LHIECKPJNFD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFD4 RID: 57300 RVA: 0x002537B4 File Offset: 0x002519B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lHIECKPJNFD_ != null)
			{
				num ^= this.LHIECKPJNFD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFD5 RID: 57301 RVA: 0x002537F0 File Offset: 0x002519F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DFD6 RID: 57302 RVA: 0x002537F8 File Offset: 0x002519F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFD7 RID: 57303 RVA: 0x00253801 File Offset: 0x00251A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lHIECKPJNFD_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.LHIECKPJNFD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFD8 RID: 57304 RVA: 0x00253834 File Offset: 0x00251A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lHIECKPJNFD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LHIECKPJNFD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x00253874 File Offset: 0x00251A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureDungeonDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lHIECKPJNFD_ != null)
			{
				if (this.lHIECKPJNFD_ == null)
				{
					this.LHIECKPJNFD = new TreasureDungeonLevel();
				}
				this.LHIECKPJNFD.MergeFrom(other.LHIECKPJNFD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x002538C8 File Offset: 0x00251AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFDB RID: 57307 RVA: 0x002538D4 File Offset: 0x00251AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.lHIECKPJNFD_ == null)
					{
						this.LHIECKPJNFD = new TreasureDungeonLevel();
					}
					input.ReadMessage(this.LHIECKPJNFD);
				}
			}
		}

		// Token: 0x040058E8 RID: 22760
		private static readonly MessageParser<TreasureDungeonDataScNotify> _parser = new MessageParser<TreasureDungeonDataScNotify>(() => new TreasureDungeonDataScNotify());

		// Token: 0x040058E9 RID: 22761
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058EA RID: 22762
		public const int LHIECKPJNFDFieldNumber = 4;

		// Token: 0x040058EB RID: 22763
		private TreasureDungeonLevel lHIECKPJNFD_;
	}
}
