using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D17 RID: 3351
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PropRogueInfo : IMessage<PropRogueInfo>, IMessage, IEquatable<PropRogueInfo>, IDeepCloneable<PropRogueInfo>, IBufferMessage
	{
		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x060095AE RID: 38318 RVA: 0x0018E009 File Offset: 0x0018C209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PropRogueInfo> Parser
		{
			get
			{
				return PropRogueInfo._parser;
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x060095AF RID: 38319 RVA: 0x0018E010 File Offset: 0x0018C210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PropRogueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x060095B0 RID: 38320 RVA: 0x0018E022 File Offset: 0x0018C222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PropRogueInfo.Descriptor;
			}
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x0018E029 File Offset: 0x0018C229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropRogueInfo()
		{
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x0018E034 File Offset: 0x0018C234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropRogueInfo(PropRogueInfo other) : this()
		{
			this.kOFBMKDKEIK_ = other.kOFBMKDKEIK_;
			this.roomId_ = other.roomId_;
			this.siteId_ = other.siteId_;
			this.oKGJFMHKDNC_ = other.oKGJFMHKDNC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x0018E088 File Offset: 0x0018C288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropRogueInfo Clone()
		{
			return new PropRogueInfo(this);
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x060095B4 RID: 38324 RVA: 0x0018E090 File Offset: 0x0018C290
		// (set) Token: 0x060095B5 RID: 38325 RVA: 0x0018E098 File Offset: 0x0018C298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KOFBMKDKEIK
		{
			get
			{
				return this.kOFBMKDKEIK_;
			}
			set
			{
				this.kOFBMKDKEIK_ = value;
			}
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x060095B6 RID: 38326 RVA: 0x0018E0A1 File Offset: 0x0018C2A1
		// (set) Token: 0x060095B7 RID: 38327 RVA: 0x0018E0A9 File Offset: 0x0018C2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x060095B8 RID: 38328 RVA: 0x0018E0B2 File Offset: 0x0018C2B2
		// (set) Token: 0x060095B9 RID: 38329 RVA: 0x0018E0BA File Offset: 0x0018C2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SiteId
		{
			get
			{
				return this.siteId_;
			}
			set
			{
				this.siteId_ = value;
			}
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x060095BA RID: 38330 RVA: 0x0018E0C3 File Offset: 0x0018C2C3
		// (set) Token: 0x060095BB RID: 38331 RVA: 0x0018E0CB File Offset: 0x0018C2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKGJFMHKDNC
		{
			get
			{
				return this.oKGJFMHKDNC_;
			}
			set
			{
				this.oKGJFMHKDNC_ = value;
			}
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x0018E0D4 File Offset: 0x0018C2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PropRogueInfo);
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x0018E0E4 File Offset: 0x0018C2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PropRogueInfo other)
		{
			return other != null && (other == this || (this.KOFBMKDKEIK == other.KOFBMKDKEIK && this.RoomId == other.RoomId && this.SiteId == other.SiteId && this.OKGJFMHKDNC == other.OKGJFMHKDNC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x0018E150 File Offset: 0x0018C350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KOFBMKDKEIK != 0U)
			{
				num ^= this.KOFBMKDKEIK.GetHashCode();
			}
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.SiteId != 0U)
			{
				num ^= this.SiteId.GetHashCode();
			}
			if (this.OKGJFMHKDNC != 0U)
			{
				num ^= this.OKGJFMHKDNC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x0018E1DA File Offset: 0x0018C3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x0018E1E2 File Offset: 0x0018C3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x0018E1EC File Offset: 0x0018C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RoomId);
			}
			if (this.SiteId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.SiteId);
			}
			if (this.OKGJFMHKDNC != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.OKGJFMHKDNC);
			}
			if (this.KOFBMKDKEIK != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.KOFBMKDKEIK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x0018E280 File Offset: 0x0018C480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KOFBMKDKEIK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KOFBMKDKEIK);
			}
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this.SiteId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SiteId);
			}
			if (this.OKGJFMHKDNC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKGJFMHKDNC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x0018E308 File Offset: 0x0018C508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PropRogueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KOFBMKDKEIK != 0U)
			{
				this.KOFBMKDKEIK = other.KOFBMKDKEIK;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			if (other.SiteId != 0U)
			{
				this.SiteId = other.SiteId;
			}
			if (other.OKGJFMHKDNC != 0U)
			{
				this.OKGJFMHKDNC = other.OKGJFMHKDNC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x0018E380 File Offset: 0x0018C580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x0018E38C File Offset: 0x0018C58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.RoomId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.SiteId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.OKGJFMHKDNC = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.KOFBMKDKEIK = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A03 RID: 14851
		private static readonly MessageParser<PropRogueInfo> _parser = new MessageParser<PropRogueInfo>(() => new PropRogueInfo());

		// Token: 0x04003A04 RID: 14852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A05 RID: 14853
		public const int KOFBMKDKEIKFieldNumber = 15;

		// Token: 0x04003A06 RID: 14854
		private uint kOFBMKDKEIK_;

		// Token: 0x04003A07 RID: 14855
		public const int RoomIdFieldNumber = 5;

		// Token: 0x04003A08 RID: 14856
		private uint roomId_;

		// Token: 0x04003A09 RID: 14857
		public const int SiteIdFieldNumber = 8;

		// Token: 0x04003A0A RID: 14858
		private uint siteId_;

		// Token: 0x04003A0B RID: 14859
		public const int OKGJFMHKDNCFieldNumber = 13;

		// Token: 0x04003A0C RID: 14860
		private uint oKGJFMHKDNC_;
	}
}
